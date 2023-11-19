using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using colores;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Entidades
{
    // Declaración del delegado para el evento de adición de vehículo
    public delegate void VehiculoSubidoEventHandler();

    public class Contenedora<T> where T : Vehiculo
    {
        //eventos
        public event VehiculoSubidoEventHandler VehiculoAgregado;
        public event VehiculoSubidoEventHandler VehiculoNoAgregado;
        public event VehiculoSubidoEventHandler VehiculoEliminado;
        public event VehiculoSubidoEventHandler VehiculoModificado;

        protected List<Vehiculo> vehiculos;
        protected static string pathPredeterminado = @".\objetos.json";
        AccesoVehiculos accesoVehiculos = new AccesoVehiculos();

        #region propertys

        public List<Vehiculo> vehiculosProperty
        {
            get { return vehiculos; }
            set { vehiculos = value; }
        }
        #endregion

        #region metodos para agregar o eliminar objetos de la lista
        public void Agregar(T vehiculo)
        {
            if (this != vehiculo)
            {
                vehiculos.Add(vehiculo);
                this.VehiculoAgregado.Invoke();
                accesoVehiculos.AgregarVehiculo(vehiculo);
            }
            else
            {
                this.VehiculoNoAgregado.Invoke();
            }
        }

        public void eliminar(int indice)
        {
            if (this == (T)(vehiculos[indice]))
            {
                accesoVehiculos.EliminarDato(vehiculos[indice]);
                vehiculos.Remove(vehiculos[indice]);
                this.VehiculoEliminado.Invoke();
            }
        }

        public void eliminar(T v)
        {
            if (this == v)
            {
                vehiculos.Remove(v);
                this.VehiculoEliminado.Invoke();
                accesoVehiculos.EliminarDato(v);
            }
        }

        public void Modificar(T v, int indice)
        {
            vehiculos[indice] = v;
            vehiculos[indice].idProperty = indice + 1;
            accesoVehiculos.ModificarDato(vehiculos[indice]);
            this.VehiculoModificado.Invoke();
        }
        #endregion

        #region sobrecarga operadores
        /// <summary>
        /// agrega un objeto a la lista dada
        /// </summary>
        /// <param name="lista">lista de vehiculos</param>
        /// <param name="v">elemento a agregar</param>
        public static Contenedora<T> operator +(Contenedora<T> lista, T v)
        {
            lista.Agregar(v);
            return lista;
        }

        /// <summary>
        /// Eliminar un objeto de una lista contenedora dada
        /// </summary>
        /// <param name="lista">lista a eliminar el objeto</param>
        /// <param name="v">objeto a eliminar</param>
        /// <returns></returns>
        public static Contenedora<T> operator -(Contenedora<T> lista, T v)
        {
            lista.eliminar(v);
            return lista;
        }

        /// <summary>
        /// Comparacion entre un objeto contenedora y un vehiculo
        /// tal que si la lista del objeto contenedora contiene
        /// un vehiculo del tipo dado, retorna verdadero
        /// </summary>
        /// <param name="lista"> Objeto contenedora que va a comparar</param>
        /// <param name="v">Vehiculo a comparar</param>
        public static bool operator ==(Contenedora<T> lista, T v)
        {
            if (lista != null)
            {
                return lista.vehiculos.Contains(v);
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Contenedora<T> lista, T v)
        {
            return !(lista.vehiculos.Contains(v));
        }

        #endregion

        #region ordenamientos
        /// <summary>
        /// Me compara ascendentemente los años en los que fueron creados
        ///los vehiculos utilizando la conversion explicita de la clase vehiculo
        /// </summary>
        /// <param name="v1"> Primer vehiculo para comparar</param>
        /// <param name="v2"> segundo vehiculo para comparar</param>
        /// <returns></returns>
        public static int OrdenarAscedentePorAño(T v1, T v2)
        {
            if (v1 > v2)
            {
                return -1;
            }
            else if (v1 < v2)
            {
                return 1;
            }
            else { return 0; }
        }

        /// <summary>
        /// Me compara descendentemente los años en los que fueron creados
        /// los vehiculos utilizando la conversion explicita de la clase vehiculo
        /// </summary>
        /// <param name="v1"> Primer vehiculo para comparar</param>
        /// <param name="v2"> segundo vehiculo para comparar</param>
        /// <returns></returns>
        public static int OrdenarDescendentePorAño(T v1, T v2)
        {
            if (v1.añoFabricacionProperty < v2.añoFabricacionProperty)
            {
                return -1;
            }
            else if (v1.añoFabricacionProperty > v2.añoFabricacionProperty)
            {
                return 1;
            }
            else { return 0; }
        }

        /// <summary>
        ///Me compara ascendentemente los años en los que fueron creados
        ///los vehiculos utilizando su atributo de velocidad maxima
        /// </summary>
        /// <param name="v1"> Primer vehiculo para comparar</param>
        /// <param name="v2"> segundo vehiculo para comparar</param>
        public static int OrdenarAscedenteVelMax(T v1, T v2)
        {
            if (v1.velMaxProperty > v2.velMaxProperty)
            {
                return -1;
            }
            else if (v1.velMaxProperty < v2.velMaxProperty)
            {
                return 1;
            }
            else { return 0; }
        }

        /// <summary>
        ///Me compara descendentemente los años en los que fueron creados
        ///los vehiculos utilizando su atributo de velocidad maxima
        /// </summary>
        /// <param name="v1"> Primer vehiculo para comparar</param>
        /// <param name="v2"> segundo vehiculo para comparar</param>
        public static int OrdenarDescendenteVelMax(T v1, T v2)
        {

            if (v1.velMaxProperty < v2.velMaxProperty)
            {
                return -1;
            }
            else if (v1.velMaxProperty > v2.velMaxProperty)
            {
                return 1;
            }
            else { return 0; }
        }
        #endregion

        public static void Serializacion(List<Vehiculo> vehiculos, string path) { }

        public static List<Vehiculo> Deserializacion(string path) 
        { 
            List<Vehiculo> listaVehiculos = new List<Vehiculo>();
            AccesoVehiculos ado = new AccesoVehiculos();

            if (ado.TestConnection())
            {
                listaVehiculos = ado.ObtenerListaVehiculos();
            }

            return listaVehiculos; 
        }

        /*
        #region serializacion
        /// <summary>
        /// A partir de una lista dada y una ruta, te serializa los objetos de la lista
        /// en un json y lo guarda en el path dado, si el path dado se determina uno
        /// predeterminado
        /// </summary>
        /// <param name="vehiculos">La lista de vehiculos a serializar</param>
        /// <param name="path">La ruta del archivo</param>
        public static void Serializacion(List<Vehiculo> vehiculos, string path)
        {
            //Si el path dado no es correcto, se utiliza uno predeterminado
            if (path == null || path.Length == 0) { path = pathPredeterminado; }
            else 
            { 
                //Si el path no contiene la extension .json, se le agrega, asi puede
                //guardarse de forma correcta
                if (!path.Contains(".json"))
                {
                    path += ".json";
                }
            }

            try //serializar
            {
                string json = JsonConvert.SerializeObject(vehiculos, Formatting.Indented);
                File.WriteAllText(path, json);
            }
            catch { }   
            
        }
        
        
        /// <summary>
        /// deserializar un json a partir de una ruta dada, y lo convierte
        /// en una lista de vehiculos
        /// </summary>
        /// <param name="path">la ruta dada</param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static List<Vehiculo> Deserializacion(string path)
        {
            //Si el path dado no es correcto, se utiliza uno predeterminado
            if (path == null || path.Length == 0) { path = pathPredeterminado;  }
            List<Vehiculo> retorno = new List<Vehiculo>();

            //Lee un archivo json y los convierte en objetos
            if (File.Exists(path))
            {
                try
                {
                    string json = File.ReadAllText(path);

                    JArray jsonArray = JArray.Parse(json);
                    foreach (JObject jsonObject in jsonArray)
                    {
                        int tipo = jsonObject["tipoProperty"].Value<int>();
                        Vehiculo v;

                        //Define que tipo de objeto es segun el atributo "Tipo"
                        //y lo castea a ese objeto
                        switch (tipo)
                        {
                            case 1:
                                v = jsonObject.ToObject<Auto>();
                                break;
                            case 2:
                                v = jsonObject.ToObject<Avion>();
                                break;
                            case 3:
                                v = jsonObject.ToObject<Tren>();
                                break;
                            default:
                                throw new InvalidOperationException("Tipo de vehículo desconocido");
                        }
                        retorno.Add(v);
                    }
                }
                catch { retorno = null; }
                
            }

            // En caso de error o si el archivo no existe, regresar una lista vacía o null según tus necesidades 
            return retorno;
        }

        #endregion
        */

    }
}

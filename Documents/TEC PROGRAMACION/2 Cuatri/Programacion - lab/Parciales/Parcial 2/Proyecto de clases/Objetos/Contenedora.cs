using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Entidades
{
    public class Contenedora
    {
        protected List<Vehiculo> vehiculos = new List<Vehiculo>();
        protected static string pathPredeterminado = @".\objetos.json";

        #region propertys

        public List<Vehiculo> vehiculosProperty
        {
            get
            {
                return vehiculos;
            }
            set { vehiculos = value; }
        }
        #endregion

        #region metodos para agregar o eliminar objetos de la lista
        public void Agregar(Vehiculo vehiculo)
        {
            if (this!=vehiculo)
            {
                vehiculos.Add(vehiculo);
            }
        }

        public void eliminar(int indice)
        {
            if (this==(vehiculos[indice]))
            {
                vehiculos.Remove(vehiculos[indice]);
            }
        }

        public void eliminar(Vehiculo v)
        {
            if (this==v)
            {
                vehiculos.Remove(v);
            }
        }
        #endregion

        #region sobrecarga operadores
        /// <summary>
        /// agrega un objeto a la lista dada
        /// </summary>
        /// <param name="lista">lista de vehiculos</param>
        /// <param name="v">elemento a agregar</param>
        public static Contenedora operator +(Contenedora lista, Vehiculo v)
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
        public static Contenedora operator -(Contenedora lista, Vehiculo v)
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
        public static bool operator ==(Contenedora lista, Vehiculo v)
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

        public static bool operator !=(Contenedora lista, Vehiculo v)
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
        public static int OrdenarAscedentePorAño(Vehiculo v1, Vehiculo v2)
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
        public static int OrdenarDescendentePorAño(Vehiculo v1, Vehiculo v2)
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
        public static int OrdenarAscedenteVelMax(Vehiculo v1, Vehiculo v2)
        {
            //Me compara ascendentemente los años en los que fueron creados
            //los vehiculos utilizando su atributo de velocidad maxima
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
        public static int OrdenarDescendenteVelMax(Vehiculo v1, Vehiculo v2)
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
            if (path == null || path.Length == 0) { path = pathPredeterminado; }
            else 
            { 
                if (!path.Contains(".json"))
                {
                    path += ".json";
                }
            }
            
            string json = JsonConvert.SerializeObject(vehiculos, Formatting.Indented);
            File.WriteAllText(path, json);
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
            if (path == null || path.Length == 0) { path = pathPredeterminado;  }

            List<Vehiculo> retorno = new List<Vehiculo>();
            //Lee un archivo json y los convierte en objetos
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);

                JArray jsonArray = JArray.Parse(json);
                foreach (JObject jsonObject in jsonArray)
                {
                    int tipo = jsonObject["tipoProperty"].Value<int>();
;                   Vehiculo v;
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

            // En caso de error o si el archivo no existe, regresar una lista vacía o null según tus necesidades 
            return retorno;
        }

        #endregion
    }
}

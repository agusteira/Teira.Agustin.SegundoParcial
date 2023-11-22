using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tipos;

namespace Entidades
{
    public class Avion : Vehiculo, IVehiculos
    {
        protected int asientos;
        protected int cantMotores;

        #region constructores
        /// <summary>
        /// Constructor para la inicializacion del objeto cuando se deserialiaza
        /// el archivo con objetos y define el estado del vehiculo como "Apagado"
        /// ya que el programa estaba apagado
        /// </summary>
        public Avion() { this.estado = "Avion en tierra"; }

        /// <summary>
        /// Constructor del objeto Avion, heredado del objeto vehiculo que posee
        /// los atributos "Asientos", y "Cantidad de motores"
        /// </summary>
        /// <param name="añoFabricacion">Año en que se fabrico el vehiculo</param>
        /// <param name="velocidadMax">Velocidad maxima que alcanza el vehiculo</param>
        /// <param name="colorPredominante">Color predominante del vehiculo</param>
        public Avion(int añoFabricacion, int velocidadMax, string colorPredominante) : base(añoFabricacion, velocidadMax, colorPredominante)
        {
            this.asientos = 0;
            this.cantMotores = 0;
            this.estado = "Avion en tierra";
            if (Enum.TryParse(typeof(enumTipos), "avion", out object result))
            {
                this.tipo = (enumTipos)result;
            }
        }

        /// <param name="asientos">Cantidad de asientos que hay en el avion</param>
        public Avion(int añoFabricacion, int velocidadMax, string marca, int asientos) : this(añoFabricacion, velocidadMax, marca)
        {
            this.asientos = asientos;
        }

        /// <param name="cantMotores">Cantidad de motores que tiene el avion</param>
        public Avion(int añoFabricacion, int velocidadMax, string marca, int asientos, int cantMotores) : this(añoFabricacion, velocidadMax, marca, asientos)
        {
            this.cantMotores = cantMotores;
        }

        #endregion

        #region propertys
        public int propertyAsientos
        {
            get { return asientos; }
            set { asientos = value; }
        }

        public int propertyCantMotores
        {
            get { return cantMotores; }
            set { cantMotores = value; }
        }


        #endregion

        #region sobreescritura ToString and Equals
        /// <summary>
        /// Sobre escritura del ToString que devuelve las caracteristicas del Avion
        /// </summary>
        public override string ToString()
        {
            return this.añoFabricacion.ToString() + " - " + this.velocidadMax.ToString() + " km/h- " + 
                 this.colorPredominante + " - Asientos: " + this.asientos.ToString() + " - Motores: " + this.cantMotores.ToString() ;
        }

        /// <summary>
        /// Sobre escritura del Equals que compara todos sus atributos
        /// para determinar si 2 Aviones son iguales
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Avion v = (Avion)obj; //Parseo el objeto a avion para entrar a sus atributos

            return (this.añoFabricacion == v.añoFabricacion && this.id == v.id
                && this.asientos == v.asientos && this.cantMotores == v.cantMotores);
        }

        #endregion

        #region sobrecarga operadores
        public static bool operator ==(Avion v1, Avion v2)
        {
            return v1.Equals(v2);
        }

        public static bool operator !=(Avion v1, Avion v2)
        {
            return !(v1.Equals(v2));
        }
        #endregion

        #region metodos
        /// <summary>
        /// Este metodo modifica varios atributos del objeto para hacer
        /// de cuenta que se "prendio" o "apago" y esta en "viaje" o "detenido"
        /// </summary>
        public override string Encender()
        {
            string retorno;
            this.definirEstado(this.apagadoEncendido);

            if (this.apagadoEncendido)
            {
                Random random = new Random();
                retorno = $"El avion a encendido sus {this.cantMotores} motores y tiene {random.Next(0, this.asientos)} pasajeros ";
            }
            else { retorno = "El avion TODOS apago sus motores"; }

            return retorno;
        }

        /// <summary>
        /// Define el estado en el que esta el Avion
        /// </summary>
        /// <param name="e">estado booleano del vehiculo</param>
        public override void definirEstado(bool e)
        {
            if (this.apagadoEncendido == false)
            {
                this.estado = $"Avion en camino";
            }
            else
            {
                this.estado = "Avion apagado";
            }
            base.definirEstado(e);
        }


        /// <summary>
        /// Descripcion final del vehiculo que se mostrara en el listbox
        /// </summary>
        /// <returns>un string con la descripcion</returns>
        public override string descripcionFinal()
        {
            string retorno;
            retorno = "AVION: " + this.ToString() + "                               " + this.estado ;
            return retorno;
        }
        #endregion
    }
}

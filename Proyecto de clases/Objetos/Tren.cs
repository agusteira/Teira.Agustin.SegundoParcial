using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tipos;

namespace Entidades
{
    public class Tren : Vehiculo, IVehiculos
    {
        protected int cantVagones;
        protected string paisOrigen;


        #region constructores
        /// <summary>
        /// Constructor para la inicializacion del objeto cuando se deserialiaza
        /// el archivo con objetos y define el estado del vehiculo como "Apagado"
        /// ya que el programa estaba apagado
        /// </summary>
        public Tren() { this.estado = "Tren estacionado";  }

        /// <summary>
        /// Constructor del objeto Tren, heredado del objeto vehiculo que posee
        /// los atributos "Cantidad de vagones", y "Pais de origen"
        /// </summary>
        /// <param name="añoFabricacion">Año en que se fabrico el vehiculo</param>
        /// <param name="velocidadMax">Velocidad maxima que alcanza el vehiculo</param>
        /// <param name="colorPredominante">Color predominante del vehiculo</param>
        public Tren(int añoFabricacion, int velocidadMax, string colorPredominante) : base(añoFabricacion, velocidadMax, colorPredominante)
        {
            this.cantVagones = 0;
            this.paisOrigen = "";
            this.estado = "Tren estacionado";
            if (Enum.TryParse(typeof(enumTipos), "tren", out object result))
            {
                this.tipo = (enumTipos)result;
            }
        }

        /// <param name="cantVagones">Cantidad de vagones del tren</param>
        public Tren(int añoFabricacion, int velocidadMax, string colorPredominante, int cantVagones) : this(añoFabricacion, velocidadMax, colorPredominante)
        {
            this.cantVagones = cantVagones;
        }

        /// <param name="paisOrigen">Paises de origen</param>
        public Tren(int añoFabricacion, int velocidadMax, string colorPredominante, int cantVagones, string paisOrigen) : this(añoFabricacion, velocidadMax, colorPredominante, cantVagones)
        {
            this.paisOrigen = paisOrigen;
        }

        #endregion

        #region propertys
        public int propertyCantVagones
        {
            get { return cantVagones; }
            set { cantVagones = value; }
        }

        public string propertyPaisOrigen
        {
            get { return paisOrigen; }
            set { paisOrigen = value; }
        }
        #endregion

        #region sobreescritura ToString and Equals
        /// <summary>
        /// Sobre escritura del ToString que devuelve las caracteristicas del tren
        /// </summary>
        public override string ToString()
        {
            return this.añoFabricacion.ToString() + " - " + this.velocidadMax.ToString() + " km/h - " 
                + this.colorPredominante + " - Cant Vagones: " + this.cantVagones.ToString() + " - Origen: " + this.paisOrigen;
        }

        /// <summary>
        /// Sobre escritura del Equals que compara todos sus atributos
        /// para determinar si 2 trenes son iguales
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Tren v = (Tren)obj; //Parseo el objeto a tren para entrar a sus atributos

            return (this.añoFabricacion == v.añoFabricacion && this.velocidadMax == v.velocidadMax && this.colorPredominante == v.colorPredominante
                && this.cantVagones == v.cantVagones && this.paisOrigen == v.paisOrigen);
        }

        #endregion

        #region sobrecarga operadores
        public static bool operator ==(Tren v1, Tren v2)
        {
            return v1.Equals(v2);
        }

        public static bool operator !=(Tren v1, Tren v2)
        {
            return !(v1.Equals(v2));
        }
        #endregion

        #region metodos

        /// <summary>
        /// Este metodo modifica varios atributos del objeto para hacer
        /// de cuenta que se "predio" o "apago" y esta en "viaje" o "detenido"
        /// </summary>
        public override string Encender()
        {
            string retorno;
            this.definirEstado(this.apagadoEncendido);

            if (this.apagadoEncendido)
            {
                retorno = "El tren ha empezado su recorrido";
            }
            else { retorno = "El tren se ha detenido"; }

            return retorno;
        }

        /// <summary>
        /// Define el estado en el que esta el Tren
        /// </summary>
        /// <param name="e">estado booleano del vehiculo</param>
        public override void definirEstado(bool e)
        {
            if (this.apagadoEncendido == false)
            {
                this.estado = "Tren en recorrido...";
            }
            else
            {
                this.estado = "Tren detenido";
            }
            base.definirEstado(e);
        }

        public override string descripcionFinal()
        {
            string retorno;
            retorno = "TREN: " + this.ToString() + "                " + this.estado;
            return retorno;
        }

        #endregion
    }
}

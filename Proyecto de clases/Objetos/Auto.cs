using colores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tipos;

namespace Entidades
{
    public class Auto : Vehiculo, IVehiculos
    {
        protected int capacidad;
        protected int volumenTanque;

        #region constructores
        /// <summary>
        /// Constructor para la inicializacion del objeto cuando se deserialiaza
        /// el archivo con objetos y define el estado del vehiculo como "Apagado"
        /// ya que el programa estaba apagado
        /// </summary>y>
        public Auto()
        {
            this.estado = "Auto apagado";
        }

        /// <summary>
        /// Constructor del objeto Auto, heredado del objeto vehiculo que posee
        /// los atributos "Capacidad"(personas), y "Volumen del tanque"
        /// </summary>
        /// <param name="añoFabricacion">Año en que se fabrico el vehiculo</param>
        /// <param name="velocidadMax">Velocidad maxima que alcanza el vehiculo</param>
        /// <param name="colorPredominante">Color predominante del vehiculo</param>
        
        public Auto(int añoFabricacion, int velocidadMax, string colorPredominante) : base(añoFabricacion, velocidadMax, colorPredominante)
        {
            this.capacidad = 0;
            this.volumenTanque = 0;
            this.estado = "auto apagado";
            if (Enum.TryParse(typeof(enumTipos), "auto", out object result))
            {
                this.tipo = (enumTipos)result;
            }
        }

        /// <param name="capacidad">Cantidad de personas que entran en el auto</param>
        public Auto(int añoFabricacion, int velocidadMax, string colorPredominante, int capacidad) : this(añoFabricacion, velocidadMax, colorPredominante)
        {
            this.capacidad = capacidad;
        }

        /// <param name="volumenTanque">Volumen del tanque de combustible</param>
        public Auto(int añoFabricacion, int velocidadMax, string colorPredominante, int capacidad, int volumenTanque) : this(añoFabricacion, velocidadMax, colorPredominante, capacidad)
        {
            this.volumenTanque = volumenTanque;
        }

        #endregion

        #region propertys
        public int propertyCapacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }

        public int propertyVolumenTanque
        {
            get { return volumenTanque; }
            set { volumenTanque = value; }
        }


        #endregion

        #region sobreescritura ToString and Equals
        /// <summary>
        /// Sobre escritura del ToString que devuelve las caracteristicas del auto
        /// </summary>
        public override string ToString()
        {
            return  this.añoFabricacion.ToString() + " - " + this.velocidadMax.ToString() + "km/h - " + this.colorPredominante + 
                " - Capacidad: " + this.capacidad.ToString() + " - Vol Tanque: " + this.volumenTanque.ToString() + " cm3";
        }

        /// <summary>
        /// Sobre escritura del Equals que compara todos sus atributos
        /// para determinar si 2 autos son iguales
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Auto v = (Auto)obj; //Parseo el objeto a auto para entrar a sus atributos

            return (this.añoFabricacion == v.añoFabricacion && this.id == v.id
                && this.capacidad == v.capacidad && this.volumenTanque == v.volumenTanque);
        }

        #endregion

        #region sobrecarga operadores
        public static bool operator ==(Auto v1, Auto v2)
        {
            return v1.Equals(v2);
        }

        public static bool operator !=(Auto v1, Auto v2)
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
                retorno = "El Auto ha arrancado";
            }
            else { retorno = "El auto se ha apagado"; }
            
            return retorno;
        }

        /// <summary>
        /// Define el estado en el que esta el Auto
        /// </summary>
        /// <param name="e">estado booleano del vehiculo</param>
        public override void definirEstado(bool e)
        {
            if (this.apagadoEncendido == false)
            {
                this.estado = "Auto en viaje...";
            }
            else
            {
                this.estado = "Auto detenido";
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
            retorno = "AUTO: " + this.ToString() + "                 " + this.estado;
            return retorno;
        }

        #endregion
    }
}

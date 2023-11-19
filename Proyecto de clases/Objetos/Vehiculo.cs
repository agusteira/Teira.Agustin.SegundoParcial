using colores;
using tipos;
using System.Drawing;
using System.Data.Common;

namespace Entidades
{
    public abstract class Vehiculo
    {
        private static int contadorID = 0;

        protected int id;
        protected int añoFabricacion;
        protected int velocidadMax;
        protected enumColor colorPredominante;

        protected enumTipos tipo;
        protected bool apagadoEncendido;
        protected string estado;

        #region contstructores
        /// <summary>
        /// Constructor que no toma ningun argumento e inicializa sus atributos
        /// los demas constructores van tomando de a unos sus atributos
        /// </summary>
        public Vehiculo()
        {
            this.añoFabricacion = 0;
            this.colorPredominante = 0;
            this.velocidadMax = 0;
            this.id = ++contadorID;
        }

        /// <param name="añoFabricacion">El año que se fabrico el vehiculo</param>
        public Vehiculo(int añoFabricacion) : this()
        {
            this.añoFabricacion = añoFabricacion;
        }

        /// <param name="velocidadMax">La velocidad maxima que alcanza el vehiculo</param>
        public Vehiculo(int añoFabricacion, int velocidadMax) : this(añoFabricacion)
        {
            this.velocidadMax = velocidadMax;
        }

        /// <param name="colorPredominante">El color predonominante del vehiculo</param>
        public Vehiculo(int añoFabricacion, int velocidadMax, string colorPredominante) : this(añoFabricacion, velocidadMax)
        {
            colorPredominante = colorPredominante.ToLower();
            if ((Enum.TryParse(typeof(enumColor), colorPredominante, out object result)) && Enum.IsDefined(typeof(enumColor), colorPredominante))
            {
                
                this.colorPredominante = (enumColor)result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("valor", "Valor no valido");
            }
        }

        #endregion

        #region propertys

        public int añoFabricacionProperty
        {
            get
            {
                return añoFabricacion;
            }
            set { añoFabricacion = value; }
        }

        public int velMaxProperty
        {
            get
            {
                return velocidadMax;
            }
            set { velocidadMax = value; }
        }

        public enumColor colorProperty
        {
            get
            {
                return colorPredominante;
            }
            set { colorPredominante = value; }
        }

        public enumTipos tipoProperty
        {
            get
            {
                return tipo;
            }
            set { tipo = value; }
        }

        public int idProperty
        {
            get { return id; }
            set 
            { 
                id = value; 
                if (id>contadorID)
                {
                    contadorID = id; //Si la ID es mayor al contador, se setea el nuevo contador de ID
                                        // a partir de la ID dada
                }
            }
        }

        #endregion

        #region sobreescritura ToString and Equals
        /// <summary>
        /// Sobreescritura del metodo ToString, que devuelve todos los datos del vehiculo
        /// </summary>
        public override string ToString()
        {
            return this.añoFabricacion.ToString() + " - " + this.velocidadMax.ToString() + " - " + this.colorPredominante;
        }

        /// <summary>
        /// Sobreescritura del metodo Equals, que compara sus atributos
        /// y define los objetos son iguales o no
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Vehiculo v = (Vehiculo)obj; //Parseo el objeto a vehiculo para entrar a sus atributos

            return (this.añoFabricacion == v.añoFabricacion && this.velocidadMax == v.velocidadMax && this.colorPredominante == v.colorPredominante);
        }

        #endregion

        #region sobrecarga operadores
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.Equals(v2);
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1.Equals(v2));
        }

        /// <summary>
        /// Sobrecarga implicita que si el Objeto vehiculo es usado como un entero
        /// este va a comparar su año de fabricacion
        /// </summary>
        public static implicit operator int(Vehiculo vehiculo)
        {
            return vehiculo.añoFabricacion;
        }


        #endregion

        #region metodos
        public abstract string Encender();

        /// <summary>
        /// A partir de booleano dado(el apagadoEncendido) del vehiculo, cambia el atributo estado
        /// a su contrario
        /// </summary>
        public virtual void definirEstado(bool estado)
        {
            this.apagadoEncendido = !estado;
        }

        #endregion

    }
}
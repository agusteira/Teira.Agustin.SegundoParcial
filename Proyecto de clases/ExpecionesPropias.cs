using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Cuando no se logra conectar correctamenta a la base de datos se 
    /// tira esta excepcion
    /// </summary>
    public class ExceptionNoConectadaABD : Exception
    {
        public ExceptionNoConectadaABD(string mensaje) : base(mensaje)
        {
            // No hay lógica de inicialización
        }
    }

    /// <summary>
    /// Cuando no se logra cambiar un dato (Agregar, eliminar, modificar) de la 
    /// base de datos, se lanza esta excepcion
    /// </summary>
    public class ExceptionNoSeLogroCambiosEnBD : Exception
    {
        public ExceptionNoSeLogroCambiosEnBD(string mensaje) : base(mensaje)
        {
            // No hay lógica de inicialización
        }
    }

    /// <summary>
    /// Cuando hay que elegir entre los 3 vehiculos, si se elige uno
    /// que esta fuera de los pretendidos, se lanza esta excepcion
    /// </summary>
    public class ExceptionVehiculoInvalido : Exception
    {
        public ExceptionVehiculoInvalido(string mensaje) : base(mensaje)
        {
            // No hay lógica de inicialización
        }
    }


}

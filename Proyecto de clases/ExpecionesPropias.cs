using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExceptionNoConectadaABD : Exception
    {
        public ExceptionNoConectadaABD(string mensaje) : base(mensaje)
        {
            // No hay lógica de inicialización
        }
    }

    public class ExceptionNoSeLogroCambiosEnBD : Exception
    {
        public ExceptionNoSeLogroCambiosEnBD(string mensaje) : base(mensaje)
        {
            // No hay lógica de inicialización
        }
    }


}

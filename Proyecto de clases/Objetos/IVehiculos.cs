using colores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tipos;

namespace Entidades
{
    public interface IVehiculos
    {
        //Descripcion de los vehiculos que luego aparecera en el textbox
        public string descripcionFinal();

        //Propertys
        int AñoFabricacion { get; set; }
        int VelocidadMaxima { get; set; }
        enumColor ColorPredominante { get; set; }
        enumTipos Tipo { get; set; }
        public int ID { get; set; }
    }
}

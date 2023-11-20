using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teira.Agustin.PrimerParcial.Forms
{
    public class Advertencias
    {
        public static void VehiculoNuevo()
        {
            MessageBox.Show("El vehiculo se agrego con Exito", "Nuevo Vehículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void VehiculoRepetido()
        {
            MessageBox.Show("El vehículo ya existe. No se agregó a la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void VehiculoEliminado()
        {
            MessageBox.Show("El vehículo se ELIMINO con exito.", "Vehiculo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void VehiculoModificado()
        {
            MessageBox.Show("El vehículo se MODIFICO con exito.", "Vehiculo Modificado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static bool FormClosing()
        {
            bool retorno = false;
            DialogResult result = MessageBox.Show("Desea cerrar el formulario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                retorno = true;
            }

            return retorno;
        }
   
        public static DialogResult ConfirmacionEliminarObjeto()
        {
            DialogResult retorno = MessageBox.Show("Queres eliminar este objeto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return retorno;
        }

        public static void PrenderVehiculo(string estado)
        {
            MessageBox.Show(estado, "On/Off", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}

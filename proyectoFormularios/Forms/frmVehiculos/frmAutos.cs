using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teira.Agustin.PrimerParcial.Forms
{
    public partial class frmAutos : frmVehiculos
    {
        public frmAutos(Entidades.Auto a) : base((Entidades.Vehiculo)a)
        {
            InitializeComponent();
            this.tipo = "auto";
            this.definirTipoParaLabels(this.tipo);
            this.txtAtributo1.Text = a.propertyCapacidad.ToString();
            this.txtAtributo2.Text = a.propertyVolumenTanque.ToString();
        }
    }
}

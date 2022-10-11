using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Grupo2_FrondEnd
{
    public partial class FormFacturas : Form
    {
        public FormFacturas()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.btnBuscar, "Buscar");
            this.ttMensaje.SetToolTip(this.btnLimpiar, "Limpiar registros de la tabla");
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString("h:mm");
            lbFecha.Text = DateTime.Now.ToShortDateString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormFacturas_Load(object sender, EventArgs e)
        {
            dgvDatos.Columns.Add("Cantidad", "Cantidad");
            dgvDatos.Columns.Add("Descripción", "Descripción");
            dgvDatos.Columns.Add("PrecioUnitario", "P/U");
            dgvDatos.Columns.Add("Cantidad", "Sub total");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            dgvDatos.Rows.Clear();
        }
    }
}

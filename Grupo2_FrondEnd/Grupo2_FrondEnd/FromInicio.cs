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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void AbrirFormulario(Form formhijo)
        {
            if (this.panelContent.Controls.Count > 0)
            {
                this.panelContent.Controls.RemoveAt(0);
            }
            formhijo.TopLevel = false;
            this.panelContent.Controls.Add(formhijo);
            formhijo.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormPro vista = new FormPro();
            AbrirFormulario(vista);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormCli vista = new FormCli();
            AbrirFormulario(vista);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormFacturas vista = new FormFacturas();
            AbrirFormulario(vista);
        }
    }
}

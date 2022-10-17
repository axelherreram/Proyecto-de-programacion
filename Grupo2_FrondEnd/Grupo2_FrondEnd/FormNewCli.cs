using Grupo2_FrondEnd.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo2_FrondEnd
{
    public partial class FormNewCli : Form
    {
        public FormNewCli()
        {
            InitializeComponent();
        }
        public static bool ValidarEmail(string comprobarImail)
        {
            string emailFormato;
            emailFormato = "\\w+([-+.']w+)*@\\w+([.']\\w+)*\\.\\w+([.']\\w+)*";
            if (Regex.IsMatch(comprobarImail, emailFormato))
            {
                if (Regex.Replace(comprobarImail, emailFormato, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Propiedades_Clientes objcliente = new Propiedades_Clientes();

                objcliente.nit = txtNit.Text;
                objcliente.nombreClient = txtNombre.Text;
                objcliente.direccion = txtDireccion.Text;
                objcliente.gmail = txtCorreo.Text;
                if (ValidarEmail(txtCorreo.Text) == false)
                {
                    DialogResult dialogResult = MessageBox.Show("Dirreccion de correo electronico invalida", "Sistema de facturación", MessageBoxButtons.OK);
                }
                objcliente.numtelefono = txtTelefono.Text;
                string respon = objcliente.PostClientes(objcliente);
                MessageBox.Show(respon);

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "Sistema de facturación");
            }
        }
    }
}

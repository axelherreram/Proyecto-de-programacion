using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Grupo2_FrondEnd
{
    public partial class FormCli : Form
    {
        public FormCli()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtId, "No es necesario si va a ingresar un cliente");
            this.ttMensaje.SetToolTip(this.btnBuscar, "Buscar");
            this.ttMensaje.SetToolTip(this.btnActuliazar, "Actualizar");
            this.ttMensaje.SetToolTip(this.btnEliminar, "Eliminar");
            this.ttMensaje.SetToolTip(this.btnGuardar, "Guardar");
            this.ttMensaje.SetToolTip(this.btnLimpiar, "Limpiar los campos");
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
            if(ValidarEmail(txtCorreo.Text) == false)
            {
                DialogResult dialogResult = MessageBox.Show("Dirreccion de correo electronico invalida", "Sistema de facturación", MessageBoxButtons.OK);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtId.Clear();
            txtNit.Clear();
            txtNombre.Clear();
        }
    }
}

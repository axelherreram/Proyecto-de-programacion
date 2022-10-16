using Grupo2_FrondEnd.Entidades;
using Newtonsoft.Json;
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
    public partial class FormPro : Form
    {
        public FormPro()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtId,"No lo digite si va a ingresar un producto");
            this.ttMensaje.SetToolTip(this.btnBuscar, "Buscar");
            this.ttMensaje.SetToolTip(this.btnActuliazar, "Actualizar");
            this.ttMensaje.SetToolTip(this.btnEliminar, "Eliminar");
            this.ttMensaje.SetToolTip(this.btnGuardar, "Guardar");
            this.ttMensaje.SetToolTip(this.btnLimpiar, "Limpiar los campos");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStrock.Clear();
            txtRam.Clear();
            txtProcesador.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar este registro", "Sistema de facturación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                PropiProductos objBorar = new PropiProductos();
                objBorar.idPro = txtId.Text;
                String Respuesta = objBorar.DELETE(objBorar);
                MessageBox.Show(Respuesta);
                txtId.Clear();
                txtNombre.Clear();
                txtPrecio.Clear();
                txtStrock.Clear();
                txtRam.Clear();
                txtProcesador.Clear();

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            try
            {
                PropiProductos objPro = new PropiProductos();
                objPro.nombreProd = txtNombre.Text;
                objPro.precioProd = txtPrecio.Text;
                objPro.stock = txtStrock.Text;
                objPro.ram = txtRam.Text;
                objPro.procesador = txtProcesador.Text;
                string respon = objPro.PostProductos(objPro);
                MessageBox.Show(respon);

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }
                
            }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PropiProductos objPro = new PropiProductos();
            objPro.idPro = txtId.Text;

            string RespuestaJson = objPro.BuscarXidProductos(objPro);
            try
            {
                if (RespuestaJson == "null")
                {
                    MessageBox.Show("ERROR: no se encontro el articulo deseado");
                    txtId.Clear();
                }
                else
                {
                    PropiProductos peli = JsonConvert.DeserializeObject<PropiProductos>(RespuestaJson);
                    txtNombre.Text = peli.nombreProd;
                    txtPrecio.Text = peli.precioProd;
                    txtStrock.Text = peli.stock;
                    txtProcesador.Text = peli.procesador;
                    txtRam.Text = peli.ram;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnActuliazar_Click(object sender, EventArgs e)
        {
            try
            {
                PropiProductos objPro = new PropiProductos();
                objPro.idPro = txtId.Text;
                objPro.nombreProd = txtNombre.Text;
                objPro.precioProd = txtPrecio.Text;
                objPro.stock = txtStrock.Text;
                objPro.ram = txtRam.Text;
                objPro.procesador = txtProcesador.Text;
                string respon = objPro.ActualizarXpro(objPro);
                MessageBox.Show(respon);

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }
        }
    }
    }


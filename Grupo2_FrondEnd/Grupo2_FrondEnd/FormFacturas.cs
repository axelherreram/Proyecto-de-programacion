using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using static System.Net.WebRequestMethods;
using Grupo2_FrondEnd.Entidades;

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
            dgvDatos.Columns.Add("Descripcion", "Descripción");
            dgvDatos.Columns.Add("PrecioUnitario", "P/U");
            dgvDatos.Columns.Add("subtotal", "Sub total");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            dgvDatos.Rows.Clear();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Guardar el archivo en local
            SaveFileDialog guardarFile = new SaveFileDialog();
            guardarFile.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
            
            //Leemos el HTMl
            string paginaHtml_texto = Properties.Resources.plantilla.ToString();
            //Info factura
            //paginaHtml_texto = paginaHtml_texto.Replace("@NRO", lbNumFactura.Text);
            paginaHtml_texto = paginaHtml_texto.Replace("@HORA", lbHora.Text);
            paginaHtml_texto = paginaHtml_texto.Replace("@FECHA", lbFecha.Text);

            //Info cliente
            paginaHtml_texto = paginaHtml_texto.Replace("@NIT", txtNit.Text);
            paginaHtml_texto = paginaHtml_texto.Replace("@CLIENTE",txtNombre.Text);
            paginaHtml_texto = paginaHtml_texto.Replace("@DIRECCION", txtDireccion.Text);

            //Escribir el valor del dataGrid
            string filas = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Descripcion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioUnitario"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["subtotal"].Value.ToString() + "</td>";
                filas += "</tr>";
                total += decimal.Parse(row.Cells["subtotal"].Value.ToString());
            }
            paginaHtml_texto = paginaHtml_texto.Replace("@FILAS", filas);
            paginaHtml_texto = paginaHtml_texto.Replace("@TOTAL", total.ToString());

            if (guardarFile.ShowDialog()== DialogResult.OK)
            {
                //crea el archivo en memoria
                using (FileStream stream = new FileStream(guardarFile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    //imagen de nuestro logo
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logoEmp,System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(80, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top -60);
                    pdfDoc.Add(img);


                    //pdfDoc.Add(new Phrase("Hola Mundo"));
                    using (StringReader sr = new StringReader(paginaHtml_texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }

            }
            {

            }
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double Total = 0;
            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                Total += Convert.ToDouble(row.Cells["subtotal"].Value);
            }
            txtTotal1.Text = Total.ToString();
            
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //PropiProductos objPro = new PropiProductos();

            int indice_fila = dgvDatos.Rows.Add();
            DataGridViewRow row = dgvDatos.Rows[indice_fila];
            string filas = string.Empty;
            decimal total = 0;
            //falta llamar el motodo
            //txtPrecio.Text = objPro.precio;
            row.Cells["Cantidad"].Value = txtCantidad.Text;
            row.Cells["Descripcion"].Value = txtDess.Text;
            row.Cells["PrecioUnitario"].Value = txtPrecio.Text;
            row.Cells["subtotal"].Value = decimal.Parse(txtCantidad.Text) * decimal.Parse(txtPrecio.Text);
            
        }

        private void btmNuevoCli_Click(object sender, EventArgs e)
        {
            Form form = new FormNewCli(); 
            form.ShowDialog();
              
        }
    }
}

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
using iTextSharp.tool.xml.html;
using static System.Net.Mime.MediaTypeNames;


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
            dgvproductos.Columns.Add("Cantidad", "Cantidad");
            dgvproductos.Columns.Add("Descripcion", "Descripción");
            dgvproductos.Columns.Add("PrecioUnitario", "P/U");
            dgvproductos.Columns.Add("subtotal", "Sub total");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            dgvproductos.Rows.Clear();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Guardar el archivo en local
           SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            //Leemos el HTMl
            string PaginaHTML_Texto = Properties.Resources.plantilla.ToString();
            //Info factura
            //paginaHtml_texto = paginaHtml_texto.Replace("@NRO", lbNumFactura.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@HORA", lbHora.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", lbFecha.Text);

            //Info cliente
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NIT", txtNit.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE",txtNombre.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DIRECCION", txtDireccion.Text);

            //Escribir el valor del dataGrid
            string filas = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in dgvproductos.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Descripcion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioUnitario"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["subtotal"].Value.ToString() + "</td>";
                filas += "</tr>";
                total += decimal.Parse(row.Cells["subtotal"].Value.ToString());
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@IVA", txtIva.Text);


            if (savefile.ShowDialog()== DialogResult.OK)
            {
               
                //crea el archivo en memoria
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 0, 0, 0, 0);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    //Agregamos un logo a nuestra factura
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logoEmp, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(70, 70);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    //Asignamos una posision a la imgagen
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);


                    
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }

            }
             
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int indice_fila = dgvproductos.Rows.Add();
            DataGridViewRow row = dgvproductos.Rows[indice_fila];
            string filas = string.Empty;

            //txtPrecio.Text = objPro.precio;
            row.Cells["Cantidad"].Value = txtCantidad.Text;
            row.Cells["Descripcion"].Value = txtDess.Text;
            row.Cells["PrecioUnitario"].Value = txtPrecio.Text;
            row.Cells["subtotal"].Value = decimal.Parse(txtCantidad.Text) * decimal.Parse(txtPrecio.Text);

        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //PropiProductos objPro = new PropiProductos();

            
            
        }

        private void btmNuevoCli_Click(object sender, EventArgs e)
        {
            Form form = new FormNewCli(); 
            form.ShowDialog();
              
        }

        private void txtCalcular_Click(object sender, EventArgs e)
        {
            double Total = 0;
            double iva = 0;
            double ivaTotal = 0;
            foreach (DataGridViewRow row in dgvproductos.Rows)
            {
                Total += Convert.ToDouble(row.Cells["subtotal"].Value);
            }
            iva = ((Total/1.12)*0.12);
            Total -= iva;
            txtIva.Text = iva.ToString("0. ##");
            txtTotal1.Text = Total.ToString("0. ##");

        }
    }
}

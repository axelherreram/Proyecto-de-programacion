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
using Newtonsoft.Json;


namespace Grupo2_FrondEnd
{
    public partial class FormFacturas : Form
    {
        public FormFacturas()
        {
            InitializeComponent();
            lbNumFactura.Text = "1";
            this.ttMensaje.SetToolTip(this.btnBuscar, "Buscar");
            this.ttMensaje.SetToolTip(this.btnLimpiar, "Limpiar registros de la tabla");
            this.ttMensaje.SetToolTip(this.btnImprimir, "Importar la factura a PDF");
            this.ttMensaje.SetToolTip(this.btnLimpearR, "Limpiar datos cliente/productos");
            lbHora.Text = DateTime.Now.ToString("h:mm");
            lbFecha.Text = DateTime.Now.ToShortDateString();
        }
       
        private void horaFecha_Tick(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormFacturas_Load(object sender, EventArgs e)
        {
            //Creacion de las columnas del data grid
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
            try
            {
            //Guardar el archivo en local
           SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            //Leemos el HTMl
            string PaginaHTML_Texto = Properties.Resources.plantilla.ToString();
                //Info factura
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NRO", lbNumFactura.Text);
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
            //Remplacamos, para escribir el total y el iva de la factura
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@IVA", txtIva.Text);


            //Abrimos el explorador para eligir el directorio para guardar la factura
            if (savefile.ShowDialog()== DialogResult.OK)
            {
                    //crea el archivo en memoria
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                     //Creamos un nuevo documento y lo definimos como PDF
                     Document pdfDoc = new Document(PageSize.A4, 22, 22, 22, 22);

                    //Escribimos en el documento
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    //Agregamos un logo a nuestra factura
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logoEmpresa, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(70, 70);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    //Asignamos una posision a la imgagen
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top -30);
                    pdfDoc.Add(img);
                    
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    }
            }
                MessageBox.Show("Factura generada con exito", "Sistema de facturación");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al imprimir la factura", "Sistema de facturación");

            }

        }

        //Descontar ya es funcional
        private void button1_Click(object sender, EventArgs e)
        {

            //Aca se va a descontar
            //Primera prueba
            PropiProductos objPro = new PropiProductos();
            objPro.idPro = txtid.Text;
            string RespuestaJson = objPro.BuscarXidProductos(objPro);
            if (RespuestaJson == null)
            {
                MessageBox.Show("Ocurrio un error", "Sistema de facturación");
            }
            else
            {
                //Variables contenedoras prueba 1
                string contNombreProd = "";
                int contStock = 0;
                string contRam = "";
                string contProcesador = "";
                string contAlmacenamiento = "";
                PropiProductos prop = JsonConvert.DeserializeObject<PropiProductos>(RespuestaJson);
                txtDess.Text = prop.nombreProd;
                txtPrecio.Text = prop.precioProd;
                contNombreProd = prop.nombreProd;
                contStock = Convert.ToInt32(prop.stock);
                contRam = prop.ram;
                contProcesador = prop.procesador;
                contAlmacenamiento = prop.almacenamiento;
                //Condicional si el cliente pide mas del stock del producto
                int cantPro = Convert.ToInt32(txtCantidad.Text);
                if (cantPro > contStock)
                {
                    MessageBox.Show("Lo sentimos no tenemos suficuente stock del producto", "Sistema de facturación");
                }
                else
                {
                    //Descontamos cantidad comprada menos el stock del producto
                    contStock -= cantPro;
                    //Mandar los cambios al servidor
                    objPro.idPro = txtid.Text;
                    objPro.nombreProd = contNombreProd;
                    objPro.precioProd = txtPrecio.Text;
                    objPro.stock = contStock;
                    objPro.ram = contRam;
                    objPro.procesador = contProcesador;
                    objPro.almacenamiento = contAlmacenamiento;
                    string respon = objPro.ActualizarXpro(objPro);
                    MessageBox.Show(respon);

                    //Agregamos los campos al data grid y calculamos el subtotal
                    int indice_fila = dgvproductos.Rows.Add();
                    DataGridViewRow row = dgvproductos.Rows[indice_fila];
                    string filas = string.Empty;
                    row.Cells["Cantidad"].Value = txtCantidad.Text;
                    row.Cells["Descripcion"].Value = txtDess.Text;
                    row.Cells["PrecioUnitario"].Value = txtPrecio.Text;
                    row.Cells["subtotal"].Value = decimal.Parse(txtCantidad.Text) * decimal.Parse(txtPrecio.Text);
            }
            }
        }
        //Buscar producto para ingresar al dataGrid
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
            PropiProductos objPro = new PropiProductos();
            objPro.idPro = txtid.Text;
            string RespuestaJson = objPro.BuscarXidProductos(objPro);
                if (RespuestaJson == "null")
                {
                    MessageBox.Show("ERROR: no se encontro el articulo deseado", "Sistema de facturación");
                    txtid.Clear();
                }
                else
                {
                    PropiProductos prop = JsonConvert.DeserializeObject<PropiProductos>(RespuestaJson);
                    txtDess.Text = prop.nombreProd;
                    txtPrecio.Text = prop.precioProd;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error", "Sistema de facturación");
            }
        }

        //Aca se va a ingresar el nuevo cliente
        private void btmNuevoCli_Click(object sender, EventArgs e)
        {
            Form form = new FormNewCli(); 
            form.ShowDialog();
        }

        private void txtCalcular_Click(object sender, EventArgs e)
        {
            try
            {
            double Total = 0;
            double iva = 0;
            foreach (DataGridViewRow row in dgvproductos.Rows)
            {
                Total += Convert.ToDouble(row.Cells["subtotal"].Value);
            }
            iva = ((Total/1.12)*0.12);
            Total -= iva;
            txtIva.Text = iva.ToString("0. ##");
            txtTotal1.Text = Total.ToString("0. ##");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "Sistema de facturación");
            }
        }

        //Buscar cliete
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            try
            {
            Propiedades_Clientes objcliente = new Propiedades_Clientes();
            objcliente.nit = txtNit.Text;
            string RespuestaJson = objcliente.BuscarXNIT(objcliente);
                if (RespuestaJson == "null")
                {
                    MessageBox.Show("ERROR: no se encontro el cliente, Ingrese el cliente antes de facturar", "Sistema de facturación");
                    txtNit.Clear();
                }
                else
                {
                    Propiedades_Clientes clie = JsonConvert.DeserializeObject<Propiedades_Clientes>(RespuestaJson);
                    txtNit.Text = Convert.ToString(clie.nit);
                    txtNombre.Text = clie.nombreClient;
                    txtDireccion.Text = clie.direccion;
                }

            }
            catch (Exception )
            {
                MessageBox.Show("ERROR");
            }
        }

        private void txtLimpiarRR_Click(object sender, EventArgs e)
        {
            txtDireccion.Clear();
            txtNit.Clear();
            txtNombre.Clear();
            txtDess.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtDireccion.Clear();
            txtid.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassFacturas objFac = new ClassFacturas();
            //Info Empresa

            objFac.nomEmpresa = "Payoner";
            objFac.ubicacion = lbUbi.Text;
            objFac.fechaEmision = DateTime.Parse(lbFecha.Text);
            objFac.horaEmision = lbHora.Text;
            //Info Cliente
            objFac.nit = Convert.ToInt32(txtNit.Text);
            objFac.nombreClient = txtNombre.Text;
            objFac.direccion = txtDireccion.Text;

            //objFac.iva = txtIva.Text;
            //objFac.total = txtTotal1.Text;

            //Info producto
            foreach (DataGridViewRow row in dgvproductos.Rows)
            {
                //objFac.cantidad = row.Cells["Cantidad"].ToString();
                //objFac.descripcion = row.Cells["Descripcion"].ToString();
                //objFac.precioU = row.Cells["PrecioUnitario"].ToString();
                //objFac.subTotal = row.Cells["subtotal"].ToString();

                string respon = objFac.PostFacturas(objFac);
                MessageBox.Show(respon);
            }
        }
    }
}

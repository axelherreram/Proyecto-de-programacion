using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo2_FrondEnd.Entidades
{
    internal class ClassFacturas
    {
        public int idFac { get; set; }
        public string nomEmpresa { get; set; }
        public string ubicacion { get; set; }
        public DateTime fechaEmision { get; set; }
        public string horaEmision { get; set; }

        //info cliente
        public int nit { get; set; }
        public string nombreClient { get; set; }
        public string direccion { get; set; }

        //Info producto
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public double precioU { get; set; }
        public double subTotal { get; set; }
        public double iva { get; set; }
        public double total { get; set; }
        

        public string PostFacturas(ClassFacturas objFac)
        {
            //Aqui es la llamada al back
            string Respuesta = "";
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:8080/api/facturas");
            try
            {
                //Armar mi peticion 
                request.ContentType = "application/json";
                request.Method = "POST";

                //Mandar la peticion  por medio de StreamWriter 
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(objFac);
                    streamWriter.Write(json);

                }
                //Este paso es hacer la llamada al BackEnd
                var response = (HttpWebResponse)request.GetResponse();

                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    Respuesta = result.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Campo vacio, no se puede procesar la petición", "Sistema de facturación");
            }
            return Respuesta;
        }
        public string allFacturas(ClassFacturas objProductos)
        {
            //aqui se manda la peticion al servidor
            string Respuesta = "";
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:8080/api/facturas");
            try
            {
                request.ContentType = "application/json";
                request.Method = "GET";

                var response = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    Respuesta = result.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Campo vacio, no se puede procesar la petición", "Sistema de facturación");
            }
            return Respuesta;
        }

    }
}

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
    internal class PropDFactura
    {
        public int idDFac { get; set; }
        //info cliente
        public int nit { get; set; }
        public string nombreClient { get; set; }
        public string direccion { get; set; }

        //Info producto
        public string cantidad { get; set; }
        public string descripcion { get; set; }
        public string precioU { get; set; }
        public string subTotal { get; set; }
        public string iva { get; set; }
        public string total { get; set; }


        public string PostDFacturas(PropDFactura objDFac)
        {
            //Aqui es la llamada al back
            string Respuesta = "";
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:8080/api/detallef");
          
                //Armar mi peticion 
                request.ContentType = "application/json";
                request.Method = "POST";

                //Mandar la peticion  por medio de StreamWriter 
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(objDFac);
                    streamWriter.Write(json);

                }
                //Este paso es hacer la llamada al BackEnd
                var response = (HttpWebResponse)request.GetResponse();

                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    Respuesta = result.ToString();
                }
            return Respuesta;
        }

    }
}

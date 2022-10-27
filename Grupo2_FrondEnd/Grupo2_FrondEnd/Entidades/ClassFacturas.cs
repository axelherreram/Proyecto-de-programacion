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
        public string idFac { get; set; }
        public string nomEmpresa { get; set; }
        public string ubicacion { get; set; }
        public string fechaEmision { get; set; }
        public string horaEmision { get; set; }

        //info cliente
        public string nit { get; set; }
        public string nombreClient { get; set; }
        public string direccion { get; set; }

        public int codPro { get; set; }
        public double precio { get; set; }
        public int cantPro { get; set; }
        public string descrip { get; set; }


        public string PostFacturas(ClassFacturas objFac)
        {
            //Aqui es la llamada al back
            string Respuesta = "";
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:8080/api/facturas");
            
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
            return Respuesta;
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Grupo2_FrondEnd.Entidades
{
    internal class PropiProductos
    {
        public string idProd { get; set; }
        public string nombreProd { get; set; }
        public DateTime fechaCaducidad { get; set; }
        public string precioProd { get; set; }
        public string stock { get; set; }
        public string PostProductos(PropiProductos objProductos)
        {
            //Aqui es la llamada al back
            string Respuesta = "";
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:8080/produc");

            //Armar mi peticion 
            request.ContentType = "application/json";
            request.Method = "POST";

            //Mandar la peticion  por medio de StreamWriter 
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(objProductos);
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
        public string BuscarXidProductos(PropiProductos objProductos)
        {
            //aqui se manda la peticion al servidor
            string Respuesta = "";
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:8080/produc?id=" + objProductos.idProd);

            request.ContentType = "application/json";
            request.Method = "GET";

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                Respuesta = result.ToString();
            }
            return Respuesta;
        }
        public string Actualizar(PropiProductos objProductos)
        {
            string Respuesta = "";
            var request = (HttpWebRequest)WebRequest.Create("hhttp://localhost:8080/produc");

            //Armar mi peticion 
            request.ContentType = "application/json";
            request.Method = "PUT";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(objProductos);
                streamWriter.Write(json);
            }
            var response = (HttpWebResponse)request.GetResponse();

            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                Respuesta = result.ToString();
            }
            return Respuesta;
        }
        public string DELETE(PropiProductos objProductos)
        {
            //Se manda la peticion al servidor
            string Respuesta = "";
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:8080/produc?id=8" + objProductos.idProd);

            //Armar mi peticion 
            request.ContentType = "application/json";
            request.Method = "DELETE";

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

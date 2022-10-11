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
        public string idProduc { get; set; }
        public string nombre { get; set; }
        public DateTime fechaCaducidad { get; set; }
        public string precio { get; set; }
        public string Stock { get; set; }
        public string PostProductos(PropiProductos objProductos)
        {
            //Aqui es la llamada al back
            string Respuesta = "";
            var request = (HttpWebRequest)WebRequest.Create("https://movie.azurewebsites.net/api/cartelera");

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
            var request = (HttpWebRequest)WebRequest.Create("https://movie.azurewebsites.net/api/cartelera?imdbID=" + objProductos.idProduc);

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
            var request = (HttpWebRequest)WebRequest.Create("https://movie.azurewebsites.net/api/cartelera?imdbID=" + objProductos.idProduc);

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
            var request = (HttpWebRequest)WebRequest.Create("https://movie.azurewebsites.net/api/cartelera?imdbID=" + objProductos.idProduc);

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

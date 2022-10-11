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
    internal class Propiedades_Clientes
    {
        public string idClientes { get; set; }
        public string borrador { get; set; }
        public string borrador1 { get; set; }
        public string borrador2{ get; set; }
        public string borrador3 { get; set; }
        public string borrador4 { get; set; }
        public string PostClientes(Propiedades_Clientes objClientes)
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
                string json = JsonConvert.SerializeObject(objClientes);
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
        public string BuscarXidProductos(Propiedades_Clientes objClientes)
        {
            //aqui se manda la peticion al servidor
            string Respuesta = "";
            var request = (HttpWebRequest)WebRequest.Create("https://movie.azurewebsites.net/api/cartelera?imdbID=" + objClientes.idClientes);

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
        public string Actualizar(Propiedades_Clientes objClientes)
        {
            string Respuesta = "";
            var request = (HttpWebRequest)WebRequest.Create("https://movie.azurewebsites.net/api/cartelera?imdbID=" + objClientes.idClientes);

            //Armar mi peticion 
            request.ContentType = "application/json";
            request.Method = "PUT";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(objClientes);
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
        public string DELETE(Propiedades_Clientes objProductos)
        {
            //Se manda la peticion al servidor
            string Respuesta = "";
            var request = (HttpWebRequest)WebRequest.Create("https://movie.azurewebsites.net/api/cartelera?imdbID=" + objProductos.idClientes);

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

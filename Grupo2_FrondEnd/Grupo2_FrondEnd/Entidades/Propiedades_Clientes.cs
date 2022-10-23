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
    internal class Propiedades_Clientes
    {
        public string nit { get; set; }
        public string nombreClient { get; set; }
        public string direccion { get; set; }
        public string gmail { get; set; }
        public string numtelefono { get; set; }

        public string PostClientes(Propiedades_Clientes objClientes)
        {
            //Aqui es la llamada al back
            string Respuesta = "";
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:8080/api/clientes");
            try
            {
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
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "Sistema de facturación");
            }
            return Respuesta;
        }
        public string BuscarXNIT(Propiedades_Clientes objClientes)
        {
            //aqui se manda la peticion al servidor
            string Respuesta = "";
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:8080/api/clientes?nit=" + objClientes.nit);
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
        public string Actualizar(Propiedades_Clientes objClientes)
        {
            string Respuesta = "";
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:8080/api/clientes");
            try
            {

            
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
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "Sistema de facturación");
            }
            return Respuesta;
        }
        public string DELETE(Propiedades_Clientes objClientes)
        {
            //Se manda la peticion al servidor
            string Respuesta = "";
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:8080/api/clientes?nit=" + objClientes.nit);
            try
            {
            //Armar mi peticion 
            request.ContentType = "application/json";
            request.Method = "DELETE";

            var response = (HttpWebResponse)request.GetResponse();

            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                Respuesta = result.ToString();
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "Sistema de facturación");
            }
            return Respuesta;
        }
    }
}

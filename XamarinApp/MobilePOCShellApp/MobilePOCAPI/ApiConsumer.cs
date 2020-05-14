using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace MobilePOCAPI
{
    public class ApiConsumer
    {
        #region Singleton
        private static ApiConsumer instance;
        public static ApiConsumer API
        {
            get
            {
                if (instance == null)
                    instance = new ApiConsumer();
                return instance;
            }
        }
        #endregion

        public ApiConsumer()
        {

        }

        private const string endpoint = "https://192.168.1.38:45456/api/User/";

        public async Task<string> GetAllASync()
        {
            using(HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync(endpoint);
                if (!string.IsNullOrEmpty(response)) return response.ToString();
                else return "";
            }
        }

        public List<T> GetListFromJson<T>()
        {
            string json = @"[{'IdUsuario':1,'Usuario1':'Madiox','Contrasena':'1111','NombreCompleto':'Matias Gaudio','Mail':'matiasgaudio @gmail.com','FechaNacimiento':'1996 - 01 - 01T00: 00:00','IdUsuarioPerfil':1,'IdUsuarioSeguridad':1},{'IdUsuario':2,'Usuario1':'Krapsus','Contrasena':'2222','NombreCompleto':'Fernando Martinez','Mail':'fernandomartinez @gmail.com','FechaNacimiento':'1997 - 01 - 01T00: 00:00','IdUsuarioPerfil':2,'IdUsuarioSeguridad':2},{'IdUsuario':3,'Usuario1':'SituationUK','Contrasena':'3333','NombreCompleto':'Bruno Garza','Mail':'brunogarza.dm @gmail.com','FechaNacimiento':'1993 - 01 - 01T00: 00:00','IdUsuarioPerfil':3,'IdUsuarioSeguridad':3}]";
            var jsonObject = JsonConvert.DeserializeObject<List<T>>(json);
            return jsonObject;
            
        }
    }
}

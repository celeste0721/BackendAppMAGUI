using BackendApp.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BackendApp.Logica
{
    public class LogObtenerPreguntasAPI
    {

        /*instanciar un main para anadir la lista y la url   */

        static async Task Main() {

            string apiUrl = "https://the-trivia-api.com/api/questions?limit=1"; /* limit 1 es para que devuelva 1 pregunta, se puede modificar*/
            List<ObtenerPreguntasApi> preguntas = await GetAsync(apiUrl);    
        }

        /* Codigo visto en clases para consumir una API*/

        static async Task<List<ObtenerPreguntasApi>> GetAsync(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode) {

                    string responseContent=await response.Content.ReadAsStringAsync();
                    List<ObtenerPreguntasApi> preguntas = JsonConvert.DeserializeObject<List<ObtenerPreguntasApi>>(responseContent);
                    return preguntas;
                }
                else {
                    Console.WriteLine("Error inesperado con el metodo GET" + response.StatusCode);
                    return new List<ObtenerPreguntasApi>();
                }

            }
        }
    }
}

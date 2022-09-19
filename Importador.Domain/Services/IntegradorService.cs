using Importador.Domain.Classes;
using Importador.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Importador.Domain.Services
{
    public class IntegradorService : IIntegradorService
    {
        public string Enviar(List<string> lista)
        {
            RespostaServico RespostaServico = new RespostaServico();



            using (var httpClient = new HttpClient())
            {
                var task = Task.Run(() => httpClient.PostAsJsonAsync("https://localhost:7170/api/Calcular", lista));
                task.Wait();
                var response = task.Result.Content.ReadAsStringAsync().Result;
                return response;


            }

            
        }
    }
}

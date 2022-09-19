using Importador.Domain.Classes;
using Importador.Domain.Interfaces.Services;
using Importador.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Importador.Web.Controllers
{

    [Route("api/[controller]")]
    public class CalcularController :  ControllerBase
    {
        private readonly IArquivoService _arquivoService;

        public CalcularController(IArquivoService arquivoService)
        {
            _arquivoService= arquivoService;
        }


        [HttpPost(Name = "Calcular")]
        public String Post([FromBody]List<String> lista)
        {
            String resposta;
            try
            {
                List<double> listNumeros = new List<double>();

                foreach(var item in lista)
                {
                    listNumeros.Add(double.Parse(item));
                }
                listNumeros =_arquivoService.Calcular(listNumeros);

                _arquivoService.GravarArquivoApi(listNumeros);

                resposta = "Arquivo enviado";
            }
            catch(Exception ex)
            {
                resposta = ex.Message;
            }

            return resposta;
        }
    }
}

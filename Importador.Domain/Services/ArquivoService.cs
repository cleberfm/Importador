using Importador.Domain.Classes;
using Importador.Domain.Interfaces.Repositories;
using Importador.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador.Domain.Services
{
    public class ArquivoService : IArquivoService
    {
        IArquivoRepository _arquivoRepository;
        public ArquivoService(IArquivoRepository arquivoRepository)
        {
            _arquivoRepository = arquivoRepository;
        }

        public List<double> Calcular(List<double> valores)
        {
            List<double> result = new List<double>();
            foreach(var valor in valores)
            {
                result.Add(valor + (valor/100)*10);

            }
            return result;
        }

        public bool GravarArquivoApi(List<double> valores)
        {
            _arquivoRepository.GravarArquivoApi(valores);

            return true;
        }

        public Arquivo LerArquivo()
        {
            return _arquivoRepository.LerArquivo();
        }
    }
}

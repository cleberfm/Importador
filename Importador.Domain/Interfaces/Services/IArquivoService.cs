using Importador.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador.Domain.Interfaces.Services
{
    public interface IArquivoService
    {
        public Arquivo LerArquivo();
        public bool GravarArquivoApi(List<double> valores);

        public List<double> Calcular(List<double> valores);
    }
}

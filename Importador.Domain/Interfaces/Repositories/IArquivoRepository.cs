using Importador.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador.Domain.Interfaces.Repositories
{
    public interface IArquivoRepository
    {
        public Arquivo LerArquivo();
        public bool GravarArquivoApi(List<double> valores);
    }
}

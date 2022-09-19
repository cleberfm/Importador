using Importador.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador.Domain.Interfaces.Services
{
    public interface IIntegradorService
    {
        public string Enviar(List<String> lista);
    }
}

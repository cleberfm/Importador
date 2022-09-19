using Importador.Domain.Classes;
using Importador.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Importador.App
{

    internal class Monitor
    {
        IArquivoService _arquivoService;
        public Monitor(IArquivoService arquivoService )
        {
            _arquivoService = arquivoService;
        }

        void IniciarMonitoramento()
        {
            Thread monitor = new Thread(MonitorarPasta);
            monitor.Start();
        }
        void MonitorarPasta()
        {
            Arquivo arquivo=null;
            while (true)
            {
                arquivo = _arquivoService.LerArquivo();
                if(arquivo != null)
                {
                    Thread threadA = new Thread(tA);
                    Thread threadB = new Thread(tB);
                    threadA.Start(arquivo.a);
                    threadB.Start(arquivo.b);
                }
                Thread.Sleep(1000);
            }
        }

        void tA(object lista)
        {

        }
        void tB(object lista)
        {

        }

    }
}

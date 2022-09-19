using Importador.Domain.Classes;
using Importador.Domain.Interfaces.Services;

namespace Importador.App
{
    public partial class frmPrincipal : Form
    {
        private readonly IArquivoService _arquivoService;
        private readonly IIntegradorService _integradorService;
        Thread threadA;
        Thread threadB;
        Thread monitor;
        Thread api;
        public frmPrincipal(IArquivoService arquivoService, IIntegradorService integradorService)
        {
            InitializeComponent();
            _arquivoService = arquivoService;
            _integradorService = integradorService;

            IniciarMonitoramento();
        }


        void IniciarMonitoramento()
        {
            monitor = new Thread(MonitorarPasta);
            monitor.Start();
        }
        void MonitorarPasta()
        {
            Arquivo arquivo = null;
            while (true)
            {
                arquivo = _arquivoService.LerArquivo();
                if (arquivo != null)
                {
                    IniciarTratamento(arquivo);
                    
                }
                Thread.Sleep(1000);
            }
        }

        void tA(object lista)
        {

            foreach (var item in (List<int>)lista)
            {
                AdicionarItemLista(item.ToString());
            }
        }
        void tB(object lista)
        {
            foreach (var item in (List<int>)lista)
            {
                while(threadA.IsAlive)
                    Thread.Sleep(1000);
                AdicionarItemLista(item.ToString());
            }
        }

        public void AdicionarItemLista(String item)
        {
            if (lstPrincipal.InvokeRequired)
            {
                lstPrincipal.Invoke(new MethodInvoker(delegate
                 {
                     lstPrincipal.Items.Add(new ListViewItem(item));

                 }));

            }
            else
            {
                lstPrincipal.Items.Add(new ListViewItem(item));
            }
        }

        public void ExibirMensagem(String texto)
        {
            MessageBox.Show( texto);

        }
        public void IniciarTratamento(Arquivo arquivo)
        {
            threadA = new Thread(tA);
            threadB = new Thread(tB);
            threadA.Start(arquivo.a);
            threadB.Start(arquivo.b);
        }

        private void lstPrincipal_DoubleClick(object sender, EventArgs e)
        {
            List<String> itens = new List<String>();
            foreach(var item in lstPrincipal.Items)
            {
                itens.Add(((ListViewItem)item).Text);
            }
            api = new Thread(IniciarApi);
            api.Start(itens);

        }

        private void IniciarApi(Object itens)
        {
            List<String> itensL = (List<String>)itens;
            var retorno = _integradorService.Enviar(itensL);

            ExibirMensagem(retorno);
        }

    }
}
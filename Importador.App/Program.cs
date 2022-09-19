using Importador.Domain.Interfaces.Repositories;
using Importador.Domain.Interfaces.Services;
using Importador.Domain.Services;
using Importador.Infra;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Importador.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<frmPrincipal>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddTransient<IArquivoService, ArquivoService>();
                    services.AddTransient<IIntegradorService, IntegradorService>();
                    services.AddTransient<IArquivoRepository, ArquivoRepository>();
                    services.AddTransient<frmPrincipal>();
                });
        }
    }
}
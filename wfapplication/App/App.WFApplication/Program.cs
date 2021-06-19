using App.CrossCutting.DependencyInjection;
using App.WFApplication.Forms.About;
using App.WFApplication.Forms.UserControls.Clientes;
using App.WFApplication.Forms.UserControls.Fornecedores;
using App.WFApplication.Forms.UserControls.Itens;
using App.WFApplication.Forms.UserControls.Operacoes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace App.WFApplication
{
    static class Program
    {
        public static IServiceProvider serviceProvider { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            // Registrar os serviços
            ConfigureServices(services);

            // Construir o objeto serviceprovider
            var serviceProvider = services.BuildServiceProvider();

            Application.Run((Form)serviceProvider.GetService(typeof(Main)));
        }

        private static void ConfigureServices(ServiceCollection Services)
        {
            Services.ConfigureServices();
            Services.ConfigureRepositories();
            
            // Form principal deve ser um singleton
            Services.AddSingleton(typeof(Main));

            // Demais forms devem ser transient
            Services.AddTransient(typeof(ucClientes));
            Services.AddTransient(typeof(ucFornecedores));
            Services.AddTransient(typeof(ucItens));
            Services.AddTransient(typeof(ucOperacoes));
            Services.AddTransient(typeof(About));
        }
    }
}
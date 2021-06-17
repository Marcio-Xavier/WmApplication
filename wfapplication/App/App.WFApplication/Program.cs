using App.CrossCutting.DependencyInjection;
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

        private static void ConfigureServices(ServiceCollection services)
        {
            services.ConfigureServices();
            //services.ConfigureRepositories();

            // Form principal deve ser um singleton
            services.AddSingleton(typeof(Main));

            // Demais forms devem ser transient
            //services.AddTransient(typeof(OthersForms));
        }
    }
}
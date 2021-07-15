using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace PAAgenda
{
    using PAAgenda.Domain.Repositories;
    using PAAgenda.Persistence.Repositories;

    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            
            services.AddTransient<IAgendaRepository, AgendaRepository>();
            ServiceProvider = services.BuildServiceProvider();
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new Menu());
        }
    }
}

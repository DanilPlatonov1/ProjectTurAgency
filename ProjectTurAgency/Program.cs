using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ProjectTurAgency.Repositories;
using ProjectTurAgency.Repositories.Implementations;
using Serilog;
using Unity;
using Unity.Microsoft.Logging;

namespace ProjectTurAgency
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
            ApplicationConfiguration.Initialize();
            Application.Run(CreateContainer().Resolve<FormAgency>());
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();

            container.AddExtension(new LoggingExtension(CreateLoggerFactory()));

            container.RegisterType<IClientRepository, ClientRepository>();
            container.RegisterType<IContractRepository, ContractRepository>();
            container.RegisterType<IContractSigningRepository, ContractSigningRepository>();
            container.RegisterType<IDiscountRepository, DiscountRepository>();
            container.RegisterType<IRouteRepository, RouteRepository>();
            container.RegisterType<ITourCompilationRepository, TourCompilationRepository>();
            container.RegisterType<ITourRepository, TourRepository>();
            container.RegisterType<ITourRouteRepository, TourRouteRepository>();
            container.RegisterType<IConnectionString, ConnectionString>();

            return container;
        }

        private static LoggerFactory CreateLoggerFactory()
        {
            var loggerFactory = new LoggerFactory();
            loggerFactory.AddSerilog(new LoggerConfiguration()
             .ReadFrom.Configuration(new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build())
             .CreateLogger());
            return loggerFactory;
        }
    }
}
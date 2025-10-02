using ProjectTurAgency.Repositories;
using ProjectTurAgency.Repositories.Implementations;
using Unity;

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

            container.RegisterType<IClientRepository, ClientRepository>();
            container.RegisterType<IContractRepository, ContractRepository>();
            container.RegisterType<IContractSigningRepository, ContractSigningRepository>();
            container.RegisterType<IDiscountRepository, DiscountRepository>();
            container.RegisterType<IRouteRepository, RouteRepository>();
            container.RegisterType<ITourCompilationRepository, TourCompilationRepository>();
            container.RegisterType<ITourRepository, TourRepository>();

            return container;
        }
    }
}
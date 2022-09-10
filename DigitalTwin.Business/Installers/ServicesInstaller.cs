using DigitalTwin.Common.Installer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DigitalTwin.Business.Installers
{
    public class ServicesInstaller : IInstaller
    {
        /// <summary>
        /// Auto register DI for service with suffix <c>Service</c> in project Business
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            var allServiceInterfaces = typeof(Assembly)
                .Assembly
                .ExportedTypes
                .Where(type => type.Name.EndsWith("Service") && type.IsInterface);

            foreach (var serviceInterface in allServiceInterfaces)
            {
                var classType = typeof(Assembly)
                .Assembly
                .ExportedTypes
                .FirstOrDefault(type => serviceInterface.IsAssignableFrom(type)
                    && serviceInterface.Name.EndsWith(type.Name)
                    && !type.IsInterface
                    && !type.IsAbstract);

                if (classType == null)
                    continue;

                services.AddScoped(serviceInterface, classType);
            }
        }
    }
}

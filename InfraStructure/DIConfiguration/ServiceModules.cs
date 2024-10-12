using InfraStructure.Implementation;
using InfraStructure.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace InfraStructure.DIConfiguration
{
    public class ServiceModules
    {
        public static void Regsiter(IServiceCollection services)
        {
            services.AddTransient<IGenericRepository, GenericRepository>();
            services.AddTransient<ILoginRepository, LoginRepository>();
			services.AddTransient<IOwnerRepository, OwnerRepository>();
            services.AddTransient<IChoiseRepository, ChoiseRepository>(); 
            services.AddTransient<ITypeRepository, TypeRepository>();
            services.AddTransient<IPropertyRepository,PropertyRepository>();
            services.AddTransient<IHomeRepository, HomeRepository>(); 
        }
    }
}

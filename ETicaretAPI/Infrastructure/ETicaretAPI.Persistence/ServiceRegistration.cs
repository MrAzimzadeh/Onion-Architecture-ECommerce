using ETicaretAPI.Application.Repostories.Customer;
using ETicaretAPI.Application.Repostories.Order;
using ETicaretAPI.Application.Repostories.Prodact;
using ETicaretAPI.Persistence.Contexts;
using ETicaretAPI.Persistence.Repositories.Customer;
using ETicaretAPI.Persistence.Repositories.Order;
using ETicaretAPI.Persistence.Repositories.Prodact;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPeristenceServices(this IServiceCollection service)
        {
            service.AddDbContext<ETicaretAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString) , ServiceLifetime.Singleton);
            service.AddSingleton<ICustomerReadRepository, CustomerReadRepository>();
            service.AddSingleton<ICustomerWriteRepository, CustomerWriteRepository>();
            service.AddSingleton<IOrderReadRepository, OrderReadRepository>();
            service.AddSingleton<IOrderWriteRepository, OrderWriteRepository>();
            service.AddSingleton<IProdactReadRepository, ProdactReadRepository>();
            service.AddSingleton<IProdactWriteRepository, ProdactWriteRepository>();


        }
    }
}
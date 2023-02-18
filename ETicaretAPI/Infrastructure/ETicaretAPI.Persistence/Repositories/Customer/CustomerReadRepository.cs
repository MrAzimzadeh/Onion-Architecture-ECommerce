using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Application.Repostories.Customer;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.Customer
{
    public class CustomerReadRepository : ReadRepository<Domain.Customer> , ICustomerReadRepository  
    {
        public CustomerReadRepository(ETicaretAPIDbContext context) : base(context)
        {

        }
    }
}

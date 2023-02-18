using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Application.Repostories.Prodact;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.Prodact
{
    public class ProdactWriteRepository  : WriteRepository<Domain.Prodact> , IProdactWriteRepository
    {
        public ProdactWriteRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}

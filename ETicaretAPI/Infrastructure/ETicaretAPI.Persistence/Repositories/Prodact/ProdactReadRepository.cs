using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Application.Repostories.Prodact;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.Prodact
{
    public class ProdactReadRepository : ReadRepository<Domain.Prodact> , IProdactReadRepository
    {
        public ProdactReadRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}

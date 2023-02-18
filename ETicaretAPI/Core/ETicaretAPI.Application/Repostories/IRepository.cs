using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.Application.Repostories
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> Table { get; }
    }
}

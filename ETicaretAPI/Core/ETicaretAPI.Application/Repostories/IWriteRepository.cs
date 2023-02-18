using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.Application.Repostories
{
    public interface IWriteRepository<T> : IRepository<T> where T : class
    {
        


    }
}

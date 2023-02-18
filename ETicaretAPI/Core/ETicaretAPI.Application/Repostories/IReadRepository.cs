using System.Linq.Expressions;
using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Application.Repostories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);
        Task<T> GetSinqleAsync(Expression<Func<T, bool>> method);
        Task<T> GetByIdAsync(string id);
    }
}

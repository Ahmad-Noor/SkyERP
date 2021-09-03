using Sky.ERP.Domain.Base;
using System.Linq.Expressions;

namespace Sky.ERP.Domain.Interfaces
{
    public interface IAsyncRepository<T> where T : Entity
    {
        Task<T> AddAsync(T entity);

        Task<T> UpdateAsync(T entity);

        Task<bool> DeleteAsync(T entity);

        Task<T> GetAsync(Expression<Func<T, bool>> expression);

        Task<List<T>> ListAsync(Expression<Func<T, bool>> expression);
    }
}

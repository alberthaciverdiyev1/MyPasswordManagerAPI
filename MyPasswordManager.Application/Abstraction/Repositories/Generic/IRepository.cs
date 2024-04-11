using MyPasswordManager.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPasswordManager.Application.Abstraction.Repositories
{
    public interface IRepository<T> where T : BaseEntity, new()
    {
        IQueryable<T> GetAll();

        Task AddAsync(T entity);
        Task<T> GetByIdAsync(int id);
        void Update(T entity);
        void Delete(T entity);
        Task SaveChangeAsync();

    }
}

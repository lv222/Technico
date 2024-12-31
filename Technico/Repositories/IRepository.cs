using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technico.Repositories
{
    public interface IRepository
    {
        public interface IRepository<T, K>
        {
            Task<T?> CreateAsync(T t);
            Task<T?> UpdateAsync(T t);
            Task<bool> DeleteAsync(K id);
            Task<T?> GetAsync(K id);
            Task<List<T>> GetAsync();
        }
    }
}

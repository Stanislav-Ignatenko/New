using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Repositories.Abstractions
{
    public interface IBaseRepository<T> where T : class
    {
        IList<T> GetAll();
        void Create(T item);
        void AddRange(IList<T> item);
        T Get(int id);
    }
}

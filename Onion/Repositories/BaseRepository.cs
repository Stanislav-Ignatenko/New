using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using Onion.Models;
using Onion.Repositories.Abstractions;

namespace Onion.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected DbSet<T> Entities { get; set; }
        protected SalesContext DbContext { get; set; }
        protected BaseRepository(SalesContext dbContext)
        {
            DbContext = dbContext;
            Entities = dbContext.Set<T>();
        }
        public IList<T> GetAll()
        {
            return Entities.ToList();
        }     
        public void Create(T item)
        {
            Entities.Add(item);
        }
        public void AddRange(IList<T> item)
        {
            Entities.AddRange(item);
        }
        public T Get(int id)
        {
            return Entities.Find(id);
        }
    }
}

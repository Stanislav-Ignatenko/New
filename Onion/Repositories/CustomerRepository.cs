using Onion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Repositories
{
    public class CustomerRepository : BaseRepository<Car>
    {
        private readonly SalesContext _dbContext;
        public CustomerRepository(SalesContext context): base(context)
        {
            _dbContext = context;
        }
    }
}

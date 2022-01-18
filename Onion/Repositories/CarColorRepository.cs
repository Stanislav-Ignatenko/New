using Onion.Models;
using Onion.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Repositories
{
    public class CarColorRepository : BaseRepository<Car>
    {
        private readonly SalesContext _dbContext;
        public CarColorRepository(SalesContext context) : base (context)
        {
            _dbContext = context;
        }
    }
}

using Onion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Repositories
{
    public class CarTypeEngineRepository : BaseRepository <Car>
    {
        private readonly SalesContext _dbContext;
        public CarTypeEngineRepository(SalesContext context) : base(context)
        {
            _dbContext = context;
        }
    }
}

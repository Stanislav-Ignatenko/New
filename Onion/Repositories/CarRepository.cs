using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using Onion.Models;
using Onion.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Repositories
{

    public class CarRepository : BaseRepository<Car>, ICarRepository
    {

        private readonly SalesContext _dbContext;
        public CarRepository(SalesContext context) : base (context)
        {
            _dbContext = context;
        }
        public Car GetByColour(string colour)
        {
            return Car.Find(colour);
        }
    }
}

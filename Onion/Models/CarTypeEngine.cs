using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Models
{
    public class CarTypeEngine : Entity
    {
        public string TypeEngine { get; set; }

        public List<Car> Car { get; set; }
    }
}

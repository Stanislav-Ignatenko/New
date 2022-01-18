using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Models
{
    public class CarModel : Entity
    {
        public string Model { get; set; }

        public List<Car> Car { get; set; }
    }
}

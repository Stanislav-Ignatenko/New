using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Models
{
    public class CarColour : Entity
    {
        public string Colour { get; set; }

        public ICollection<Car> Car { get; set; }
    }
}

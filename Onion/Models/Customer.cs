using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Models
{
    public class Customer : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public List<Car> Car { get; set; }
    }
}

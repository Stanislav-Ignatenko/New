using System;

namespace Onion.Models
{
    public class Car : Entity
    {
        public int Price { get; set; }

        public int CustomerId { get; set; }
        public Customer Customers { get; set; }
        public int ModelId { get; set; }
        public CarModel CarModels { get; set; }

        public int ColourId { get; set; }
        public CarColour CarColours  {get; set;}

        public int TypeEngineId { get; set; }
        public CarTypeEngine CarTypeEngines { get; set; }

        internal static Car Find(string colour)
        {
            throw new NotImplementedException();
        }
    }
}

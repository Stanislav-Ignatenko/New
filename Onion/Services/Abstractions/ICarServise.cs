using Onion.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Services.Abstractions
{
    public interface ICarServise
    {
        IList<SortedCarDTO> GetSortedCars();
    }
}

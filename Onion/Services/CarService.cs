using Onion.DTOs;
using Onion.Repositories;
using Onion.Repositories.Abstractions;
using Onion.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Onion.Services
{
    public class CarService : ICarServise
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

   
        public IList<SortedCarDTO> GetSortedCars()
        {
            var cars = _carRepository.GetAll();

            var unsortedCars = new List<SortedCarDTO>();

            foreach (var car in cars)
            {
                var unsortedCar = new SortedCarDTO
                {
                    CarModel = car.CarModels.Model,
                
                    CustomerName = car.Customers.Name,
                };

                unsortedCars.Add(unsortedCar);
            }

            var sortedCars = GetSortedCars(unsortedCars);

            return sortedCars;
        }

        private IList<SortedCarDTO> GetSortedCars(IList<SortedCarDTO> unsortedCars)
        {
            var sortedCars = new List<SortedCarDTO>();

            sortedCars = unsortedCars.OrderBy(d => d.CustomerName).ToList(); 

            return sortedCars;
        }
    }
}

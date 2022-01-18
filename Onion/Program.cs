using Onion.Models;
using Onion.Repositories;
using Onion.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Onion
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new SalesContext();
            var carRepository = new CarRepository(dbContext);
            var carService = new CarService(carRepository);

            //var sortedCars = carService.GetSortedCars();

            //foreach (var car in sortedCars)
            //{
            //    Console.WriteLine(car.CarModel + " " + car.CustomerName);
            //}


            //CARMODELS
            var mercedes = new CarModel
            {
                Model = "Mercedes"
            };
            var BMW = new CarModel
            {
                Model = "BMW"
            };
            var ford = new CarModel
            {
                Model = "Ford"
            };

            //CUSTOMERS
            var customer1 = new Customer()
            {
                Name = "Ruslan",
                Surname = "Emelyanenko"
            };
            var customer2 = new Customer()
            {
                Name = "Anna",
                Surname = "Khalikova"
            };
            var customer3 = new Customer()
            {
                Name = "John",
                Surname = "Lee"
            };

            //COLOURS
            var red = new CarColour()
            {
                Colour = "Red"
            };
            var green = new CarColour()
            {
                Colour = "Green"
            };
            var black = new CarColour()
            {
                Colour = "Black"
            };

            //TypeEngine
            var diesel = new CarTypeEngine()
            {
                TypeEngine = "Diesel"
            };
            var petrol = new CarTypeEngine()
            {
                TypeEngine = "Petrol"
            };
            var electric = new CarTypeEngine()
            {
                TypeEngine = "Electric"
            };



            var customer = dbContext.Customers.FirstOrDefault(c => c.Name == "Ruslan" && c.Surname == "Emelyanenko");

            var sold1 = new Car
            {
                Price = 9000,
                Customers = new Customer
                {
                    Name = "Creace",
                    Surname = "Rea"
                },
                ModelId = 1,
                ColourId = 1,
                TypeEngineId = 1
            };
            var sold2 = new Car
            {
                Price = 4000,
                Customers = customer,
                ModelId = 2,
                ColourId = 2,
                TypeEngineId = 2,
            };
            var sold3 = new Car
            {
                Price = 7000,
                CustomerId = 2,
                ModelId = 3,
                ColourId = 3,
                TypeEngineId = 3,
            };




            var models = new List<CarModel>
            {
                mercedes, BMW, ford
            };

            var customers = new List<Customer>
            {
                customer1, customer2, customer3
            };

            var colours = new List<CarColour>
            {
                red, green, black
            };

            var tipeEngines = new List<CarTypeEngine>
            {
                diesel,
                petrol,
                electric
            };

            var sold = new List<Car>
            {
                sold1, sold2, sold3
            };


            //dbContext.CarModels.AddRange(models);
            //dbContext.Customers.AddRange(customers);
            //dbContext.CarColours.AddRange(colours);
            //dbContext.CarTypeEngines.AddRange(tipeEngines);
            //dbContext.Cars.AddRange(sold);

            //dbContext.SaveChanges();










            //CARMODELS Можно добавить по одному объекту

            //dbContext.CarModels.Add(Mercedes);
            //dbContext.CarModels.Add(BMW);
            //dbContext.CarModels.Add(Ford);

            //Или можно добавить сразу группу объектов

            //var car = new List<CarModel>
            //{
            //BMW,
            //Ford,
            //Mercedes
            //};
            //dbContext.CarModels.AddRange(car);























        }
    }
} 
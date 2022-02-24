using Onion.DTOs;
using Onion.Models;
using Onion.Repositories;
using Onion.Services;
using System;
using System.Collections.Generic;

namespace Onion
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new SalesContext();

            var carRepository = new CarRepository(dbContext);
            var carModelRepository = new CarModelRepository(dbContext);
            var carColourRepository = new CarColorRepository(dbContext);
            var carTypeEngineRepository = new CarTypeEngineRepository(dbContext);
            var carCustomerRepository = new CustomerRepository(dbContext);

            var carService = new CarService(carRepository,carModelRepository, carColourRepository, carTypeEngineRepository, 
                carCustomerRepository);




            //var sold1 = new CarDto
            //{
            //    Name = "Creace",
            //    Surname = "Rea",
            //    Price = 15000,
            //    Model = "BMW",
            //    Colour = "Red",
            //    TypeEngine = "Diesel"
            //};
            //carService.Update(sold1);

            //var sold2 = new CarDto
            //{
            //    Name = "Anna",
            //    Surname = "Khalikova",
            //    Price = 40,
            //    Model = "BMW",
            //    Colour = "Green",
            //    TypeEngine = "Diesel"
            //};
            //carService.Update(sold2);

            //var sold3 = new CarDto
            //{
            //    Name = "Ruslan",
            //    Surname = "Emelyanenko",
            //    Price = 70,
            //    Model = "Ford",
            //    Colour = "Black",
            //    TypeEngine = "Electric",
            //};
            //carService.Update(sold3);

            //var list = new List<Product>
            //{
            //      new Product
            //      {
            //          Name = "Milk",
            //          maker= "Korovka",
            //          experationDate= "Week"
            //      },
            //      new Product
            //      {
            //          name = "Bread",
            //          maker = "BelBread",
            //          experationDate = "HalfWeek"
            //      }
            //};







            //breadRack1 = new Bread { HeadIngridient = "flour", Name = "Milk", Maker = "Korovka", ExperationDate = "week" };

            //Bread breadRacks = new Bread(headIngridient = "Flour", new Product(name = "Milk", maker = "Korovka", experationDate = "week");
            //{
            //HeadIngridient = "flour",
            //var product = new Product
            //    {
            //        Name = "Milk",
            //        Maker = "Korovka",
            //        ExperationDate = "week"
            //    }
            //};
            //Console.WriteLine(breadRacks);


            //ChatServer serv = new ChatServer();
            //serv.SendAdminMessage(textBox1.Text);



            //Milk milkRack = new Milk();
            //milkRack.Maker = "mmm";


            //Создал два объекта
            Bread breadRacks = new Bread("flour", "Bread", "BelBread", "Week");
            Milk milkRacks = new Milk("Farm", "Milk", "Korovka", "Week");

            //Создал 5 списков (полок)- 3 списка для хлеба и 2 списка для молока
            Racks<Bread> racksBread1 = new Racks<Bread>();
            Racks<Bread> racksBread2 = new Racks<Bread>();
            Racks<Bread> racksBread3 = new Racks<Bread>();

            Racks<Milk> racksMilk1 = new Racks<Milk>();
            Racks<Milk> racksMilk2 = new Racks<Milk>();

            //Заполнил полки хлебом и молоком 
            
            for (int i = 0; i < 30; i++)
            {              
                racksBread1.AddProducts(breadRacks);
            }         
            for (int i = 0; i < 40; i++)
            {
                racksBread2.AddProducts(breadRacks);
            }           
            for (int i = 0; i < 40; i++)
            {              
                racksBread3.AddProducts(breadRacks);
            }
            Console.WriteLine($" Bread:{Racks<Bread>.Count}");

            for (int i = 0; i < 40; i++)
            {
                racksMilk1.AddProducts(milkRacks);
            }         
            for (int i = 0; i < 45; i++)
            {
                racksMilk2.AddProducts(milkRacks);
            }
            Console.WriteLine($" Milk:  {Racks<Milk>.Count}");






            //var breadRacks1 = new Bread()
            //{
            //    HeadIngridient = "flour",
            //    Name = "Milk",
            //    Maker = "Korovka",
            //    ExperationDate = "Week"
            //};



        }


    }

    //разработайте абстрактный класс, описывающий продукт Product
    abstract public class Product
    {
        public string Name { get; set; }
        public string Maker { get; set; }
        public string ExperationDate { get; set; }
        public static int Count { get; set; }
        //public Product(string name, string maker, string experationDate)
        //{
        //    Name = name;
        //    Maker = maker;
        //    ExperationDate = experationDate;
        //}
    }
    //Разработайте производный класс Bread от класса Product
    public class Bread : Product
    {
        public string HeadIngridient { get; set;}
     
        public Bread(string headIngridient, string name, string maker, string experationDate) 
            //: base (name, maker, experationDate)
        {
            HeadIngridient = headIngridient;
        }
    }
    //Разработайте производный класс Milk от класса Product
    public class Milk : Product
    {
        public string FarmAdress { get; set; }
        public Milk (string farmAdress, string name, string maker, string experationDate) 
            //: base (name, maker, experationDate)
        {
            FarmAdress = farmAdress;
        }
    }
    //Разработайте класс, описывающий полку в магазине стеллажей.
    //Класс должен быть обобщенным и ограниченным классом продукта (на полке могут храниться только продукты).

    public class Racks <T> where T : class
    {
        public List<T> List { get; set; }
        public static int Count { get; set; }
        public Racks (List<T> list)
        {
            List = list;
        }
        public Racks()
        {
            List = new List<T>();
            
        }
        //Создайтe метод добовляющий продукты в список
        public void AddProducts(T name)
        {
            List.Add(name);
            Count++;
        }
      
    }















    //public class list<T> where T : class
    //{
    //    public List<T> Get()
    //    {
    //        return   
    //    }
    //}

}
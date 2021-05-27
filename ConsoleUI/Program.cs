using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car { BranId = 1, ColorId = 1, ModelYear = "2021", DailyPrice = 3500, Description = "Sıfır Araç" };
            Car car2 = new Car { BranId = 2, ColorId = 2, ModelYear = "2018", DailyPrice = 7500, Description = "İkinci El" };
            Car car3 = new Car { BranId = 2, ColorId = 2, ModelYear = "2015", DailyPrice = 1500, Description = "Hasarlı" };

            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(car1);
            carManager.Add(car2); 
            carManager.Add(car3);

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.BranId + " " + car.ColorId + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
            //}

            Console.WriteLine(carManager.Get(5).Description);


            // Console.WriteLine(carManager.Get().Description);

            Console.ReadLine();
        }
    }
}

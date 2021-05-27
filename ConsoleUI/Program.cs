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
            Car car1 = new Car { Id = 1, BranId = 1, ColorId = 1, ModelYear = 2021, DailyPrice = 3500, Description = "Sıfır Araç" };
           
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(car1);
                 
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }


            // Console.WriteLine(carManager.Get().Description);

            Console.ReadLine();
        }
    }
}

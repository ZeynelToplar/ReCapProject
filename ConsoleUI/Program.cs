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
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //carManager.Add(new Car { BranId = 1, ColorId = 1, CarName = "Mustang", ModelYear = "2021", DailyPrice = 3500, Description = "Sıfır Araç" });
            //brandManager.Add(new Brand { BrandId = 2, BrandName = "Toyota" });
            //colorManager.Add(new Color { ColorId = 1, ColorName = "Siyah" });

            GetCarDetailTest(carManager);


            //CarTest(carManager);


            Console.ReadLine();
        }

        private static void GetCarDetailTest(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
            }
        }

        private static void CarTest(CarManager carManager)
        {
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BranId + " " + car.ColorId + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
            }
        }
    }
}

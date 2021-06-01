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
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            UserManager userManager = new UserManager(new EfUserDal());

            //carManager.Add(new Car { BranId = 1, ColorId = 1, CarName = "Mustang", ModelYear = "2021", DailyPrice = 3500, Description = "Sıfır Araç" });
            //brandManager.Add(new Brand { BrandId = 2, BrandName = "Toyota" });
            //colorManager.Add(new Color { ColorId = 1, ColorName = "Siyah" });

            //GetCarDetailTest(carManager);
            //CarTest(carManager);

            rentalManager.Add(new Rental { CarId = 1, CustomerId = 1, RentDate = (new DateTime(2021, 06, 01, 11, 32, 45)), ReturnDate = (new DateTime(2021, 06, 03, 11, 0, 0)) });

            var result = rentalManager.GetAll();
            if (result.Success)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.CarId + "/" + rental.RentDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            


            Console.ReadLine();
        }

        private static void GetCarDetailTest(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
            }
        }

        private static void CarTest(CarManager carManager)
        {
            var result = carManager.GetAll();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandId + " " + car.ColorId + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }
    }
}

﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BranId=1,ColorId=1,ModelYear=2018,DailyPrice=3000,Description="BMW"},
                new Car{Id=2, BranId=2,ColorId=1,ModelYear=2014,DailyPrice=6500,Description="Toyota"},
                new Car{Id=3, BranId=3,ColorId=1,ModelYear=1998,DailyPrice=1500,Description="Tofaş"},
                new Car{Id=4, BranId=4,ColorId=2,ModelYear=2005,DailyPrice=5000,Description="Audi"},
                new Car{Id=5, BranId=5,ColorId=3,ModelYear=2020,DailyPrice=15000,Description="Ferrari"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BranId = car.BranId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}

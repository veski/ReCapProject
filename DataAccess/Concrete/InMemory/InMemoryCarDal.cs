using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, ColorId=1, BrandId=1, ModelYear=2000, DailyPrice=50000, Description="Tofaş"},
                new Car{CarId=2, ColorId=1, BrandId=1, ModelYear=2010, DailyPrice=75000, Description="Reno"},
                new Car{CarId=3, ColorId=2, BrandId=2, ModelYear=2020, DailyPrice=90000, Description="Toyata"},
                new Car{CarId=4, ColorId=3, BrandId=3, ModelYear=2021, DailyPrice=150000, Description="Honda"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = new Car();
            foreach (var item in _cars)
            {
                if (car.CarId==item.CarId)
                {
                    carToDelete = item;
                }
            }
            carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(p => p.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}

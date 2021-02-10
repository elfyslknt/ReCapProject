using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{CarId=1,ColorId=2,BrandId=2,DailyPrice=100,ModelYear=2018,Description="Kapsamlı sigorta isterseniz ofiste ödeme yapabilirsiniz."},
                new Car{CarId=2,ColorId=2,BrandId=2,DailyPrice=400,ModelYear=2020,Description="Taksit mevcuttur."},
                new Car{CarId=3,ColorId=3,BrandId=1,DailyPrice=280,ModelYear=2019,Description="3 günden sonrası için günlük 200 TL."}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deleteCar=_cars.SingleOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(deleteCar);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c=>c.CarId==carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car updateCar=_cars.SingleOrDefault(c => c.CarId == car.CarId);
            updateCar.CarId = car.CarId;
            updateCar.BrandId = car.BrandId;
            updateCar.ColorId = car.ColorId;
            updateCar.DailyPrice = car.DailyPrice;
            updateCar.Description = car.Description;
            updateCar.ModelYear = car.ModelYear;

        }
    }
}

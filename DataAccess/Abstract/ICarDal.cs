using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        //InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlarını yazınız.
        List<Car> GetAll();
        List<Car> GetById(int carId);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}

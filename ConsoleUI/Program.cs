using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //Car car1 = new Car() { CarId = 6, BrandId = 1, ColorId = 1, DailyPrice = 450, Description = "225 km kadar hıza ulaşabilir.", ModelYear = 2018, CarName= "Mercedes c180" };

            //carManager.Add(car1);

            //Brand brand1 = new Brand() { BrandId = 8, BrandName = "Honda" };

            //brandManager.Add(brand1);



            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);
            //}

            // Car cardel = new Car() { CarId = 5 }; 

            //carManager.Delete(cardel);


            //CarName, BrandName, ColorName, DailyPrice
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName +"  "+car.BrandName +"  "+car.ColorName+"  "+car.DailyPrice);
            }

            //carManager.Delete(new Car { CarId=2});

            //Console.WriteLine("carId 2 olan silindi!!!");

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarId);
            //}





        }
    }
}

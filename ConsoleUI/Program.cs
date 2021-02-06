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

            //Car car1 = new Car() { CarId = 5, BrandId = 2, ColorId = 1, DailyPrice = 400, Description = "Keyifli Sürüşler.", ModelYear = 2020 };

            //carManager.Add(car1);

            Brand brand1 = new Brand() { BrandId =6,BrandName= "Renault" };

            brandManager.Add(brand1);

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }

            // Car cardel = new Car() { CarId = 5 }; 

            //carManager.Delete(cardel);


            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
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

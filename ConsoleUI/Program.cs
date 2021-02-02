﻿using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Car car1 = new Car() { CarId = 4, BrandId = 2, ColorId = 1, DailyPrice = 800, Description = "Keyifli Sürüşler.", ModelYear = 2020 };

            carManager.Add(car1);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            carManager.Delete(new Car { CarId=2});

            Console.WriteLine("carId 2 olan silindi!!!");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId);
            }





        }
    }
}
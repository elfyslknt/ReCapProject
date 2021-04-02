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
            //Car();
            //Brand();
            //User();
            //Customer();

            RentalManager rentalManager = new RentalManager(new EfRentalDal());



            Rental rental1 = new Rental() { CarId = 4, CustomerId = 3 , RentDate=new DateTime(2021, 02, 18) };

            var result = rentalManager.Add(rental1);
            Console.WriteLine(result.Message);
        }

        private static void Customer()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer customer1 = new Customer() { UserId = 3, CompanyName = "Kartal Yapı" };

            var result = customerManager.Add(customer1);
            Console.WriteLine(result.Message);
        }

        //private static void User()
        //{
        //    UserManager userManager = new UserManager(new EfUserDal());
        //    User user1 = new User() { UserFirstName = "Bahar", UserLastName = "Yağmur", UserEmail = "baharbahar@gmail.com", UserPassword = "12345" };

        //    var result = userManager.Add(user1);
        //    Console.WriteLine(result.Message);
        //}

        private static void Brand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());


            //Brand brand1 = new Brand() { BrandId = 9, BrandName = "Ford" };

            //brandManager.Add(brand1);



            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void Car()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "  " + car.BrandName + "  " + car.ColorName + "  " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            //Car car1 = new Car() { CarId = 8, BrandId = 5, ColorId = 3, DailyPrice = 500, Description = "Güvenlikli sürüş keyfi", ModelYear = 2020, CarName = "Volvo s60" };

            //Console.WriteLine(carManager.Add(car1).Message);



            //carManager.Delete(new Car { CarId=2});

            //Console.WriteLine("carId 2 olan silindi!!!");

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarId);
            //}
        }
    }
}

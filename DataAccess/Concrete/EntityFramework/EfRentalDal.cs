using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfRepositoryBase<Rental, RentCarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
           
                using (RentCarContext context = new RentCarContext())
                {
                    var result = from r in context.Rentals
                                 join cs in context.Customers
                                 on r.CustomerId equals cs.CustomerId
                                 join c in context.Cars
                                 on r.CarId equals c.CarId
                                 join b in context.Brands
                                 on c.BrandId equals b.BrandId
                                 join u in context.Users
                                 on cs.UserId equals u.UserId
                                 select new RentalDetailDto
                                 {
                                     RentalId = r.RentalId,
                                     BrandName = b.BrandName,
                                     FirstName = u.FirstName+ " "+u.LastName,
                                     RentDate = r.RentDate,
                                     ReturnDate = r.ReturnDate
                                 };
                    return result.ToList();
                }

            }
        
    }
}

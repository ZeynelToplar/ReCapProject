using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal: EfEntityRepositoryBase<Rental, MyDBContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (MyDBContext context = new MyDBContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join u in context.Users
                             on r.CustomerId equals u.Id
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new RentalDetailDto
                             {
                                 BrandName = b.BrandName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName
                             };
                return result.ToList();

            }
        }
    }
}

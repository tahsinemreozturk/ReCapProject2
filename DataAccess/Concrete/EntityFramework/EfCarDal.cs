using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.Id equals b.BrandId
                             select new CarDetailDto
                             {
                                 BrandId = b.BrandId,
                                 CarName = c.CarName,
                                 ColorId = c.ColorId,
                                 ProductName = c.ProductName,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 BrandName = b.BrandName
                             };
                return result.ToList();

            }
        }
    }
}

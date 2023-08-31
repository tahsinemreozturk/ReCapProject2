using DataAccess.Absract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2001, DailyPrice = 1100, Description = "2 Yillik Tecrubesi olanlara temin edilir"  },
                new Car { Id = 2, BrandId = 2, ColorId = 1, ModelYear = 2012, DailyPrice = 1400, Description = "3 Yillik Tecrubesi olanlara temin edilir"  },
                new Car { Id = 3, BrandId = 3, ColorId = 2, ModelYear = 2022, DailyPrice = 1850, Description = "3 Yillik Tecrubesi olanlara temin edilir"  },
                new Car { Id = 4, BrandId = 1, ColorId = 1, ModelYear = 2023, DailyPrice = 3100, Description = "5 Yillik Tecrubesi olanlara temin edilir"  },
            };
        }
        public void Add(Car cars)
        {
            _cars.Add(cars);
        }

        public void Delete(Car cars)
        {
            Car carsToDelete = _cars.SingleOrDefault(c => c.Id == c.Id);
            _cars.Remove(carsToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c=> c.BrandId == brandId).ToList();
        }

        public void Update(Car cars)
        {
            Car carsToDelete = _cars.SingleOrDefault(c => c.Id == c.Id);
            carsToDelete.DailyPrice = cars.DailyPrice;
            carsToDelete.Description = cars.Description;
        }
    }
}

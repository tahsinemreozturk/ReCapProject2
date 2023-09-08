using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        //Bir veritabanindan geliyormus gibi simule ediyoruz 
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 600, ModelYear = 2018, Description = " Fiat Doblo " },
                new Car { Id = 2, BrandId = 1, ColorId = 2, DailyPrice = 1600, ModelYear = 2020, Description = " Fiat Egea " },
                new Car { Id = 3, BrandId = 2, ColorId = 1, DailyPrice = 15500, ModelYear = 2021, Description = " Mercedes EQ " },
                new Car { Id = 4, BrandId = 1, ColorId = 3, DailyPrice = 900, ModelYear = 2019, Description = " Fiat Linea " },
            };


        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(int id)
        {
            Car carsToDelete = _cars.SingleOrDefault(c => c.Id == c.Id);
            _cars.Remove(carsToDelete);
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()//Veritabanimdaki urunleri business istedigi zaman gonderme yapacak kod
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            Car carsId = _cars.SingleOrDefault(c => c.Id == c.Id);
            return carsId;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carsToUpdate = _cars.SingleOrDefault(c => c.Id == c.Id);
            carsToUpdate.DailyPrice = car.DailyPrice;
            carsToUpdate.Description = car.Description;
        }
    }
}

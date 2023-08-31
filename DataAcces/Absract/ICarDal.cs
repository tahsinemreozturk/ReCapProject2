using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Absract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        List<Car> GetById(int brandId);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);



    }
}

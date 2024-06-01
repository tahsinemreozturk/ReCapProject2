using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDto>> GetCarsByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetCarsByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<CarDetailDto>> GetCarDetailByCarId(int carId);
        IDataResult<List<CarDetailDto>> GetCarDetailByColorAndBrandId(int brandId, int colorId);
        IDataResult<List<CarDetailDto>> GetById(int Id);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
 
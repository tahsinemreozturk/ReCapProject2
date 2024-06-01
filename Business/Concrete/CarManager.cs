using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCutingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService

    {
        ICarDal _carDal; //Farkli ortamlara geciste kolaylik saglamasi icin burada bir referasn tutucu blogu olustuuruyoruz.
                         //Bu bugun Sql yarin MySql baska bir gunde PostgreSql referansi tutabilir

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [SecuredOperation("admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            //if (car.CarName.Length >= 2 && car.DailyPrice > 0)
            //{
            //    _carDal.Add(car);
            //    return new SuccessResult(Constants.Messages.CarAdded);
            //}

            //ValidationTool.Validate(new CarValidator(),car); burayı attiributte ile hallettik.
            try
            {
                _carDal.Add(car);
                return new SuccessResult(Constants.Messages.CarAdded);
            }
            catch (Exception ex)
            {
                // Hata durumunda
                // Loglama yapılır
                return new ErrorResult(Constants.Messages.CarNoAdded);
            }
          
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDelete);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==09)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenacneTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.ProductsListed);    
        }

        public IDataResult<List<CarDetailDto>> GetById(int carId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailByCarId(carId));
        }


        public IDataResult<List<CarDetailDto>> GetCarDetailByCarId(int carId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailByCarId(carId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailByColorAndBrandId(int brandId, int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailByColorAndBrandId(brandId, colorId).ToList());
        }

        public IDataResult <List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails().ToList());

        }

        public IDataResult<List<CarDetailDto>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailByBrandId(brandId).ToList());
        }

        public IDataResult <List<CarDetailDto>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>> (_carDal.GetCarDetailByColorId(colorId).ToList());  
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdate);
        }
    }
}

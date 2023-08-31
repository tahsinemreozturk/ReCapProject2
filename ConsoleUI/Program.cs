using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        CarManager carManager = new CarManager(new EfCarDal());
        
        foreach (var cars in carManager.GetCarsByBrandId(1))
        {
            Console.WriteLine(cars.CarName);
        }

        //carManager.Add(new Car
        //{
        //    CarName = "E",
        //    Id = 2,
        //    DailyPrice = 0,
        //}) ;

    }
}
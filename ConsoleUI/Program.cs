using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        CarTest();





    }

    private static void CarTest()
    {
        CarManager carManager = new CarManager(new EfCarDal());

        foreach (var brandid in carManager.GetCarsByBrandId(1)) 
        {
            Console.WriteLine(brandid.CarName + " " + brandid.BrandId);
        }



    }
}

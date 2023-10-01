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
        
        var result = carManager.GetCarsByBrandId(1);

        if (result.Success==true)
        {
            foreach (var brandid in result.Data)
            {
                Console.WriteLine(brandid.CarName + " " + brandid.BrandId);
            }  
            
        }
        else
        {
            Console.WriteLine(result.Message);
        }

         



    }
}

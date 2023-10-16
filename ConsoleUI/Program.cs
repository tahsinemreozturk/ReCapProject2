using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        //RentalTest();
        //CarTest();
        //BrandTest();
        //CustomerAddTest();
        //UserAddTest();
        //ColorTest();

    }

    private static void RentalTest()
    {
        RentalManager rentalManager = new RentalManager(new EfRentalDal());

        var result = rentalManager.Add(new Rental { Id = 323, CarId ="32", CustomerId = "32", RentDate = new DateTime(2023, 11, 14, 8, 0, 0) });
        Console.WriteLine(result.Message);

    }

    private static void CustomerAddTest()
    {
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

        var result = customerManager.Add(new Customer { UserId = 313, CompanyName = "ozturk" });
        Console.WriteLine(result.Message);
    }

    private static void UserAddTest()
    {
        UserManager userManager = new UserManager(new EfUserDal());

        var result = userManager.Add(new User { Id= 15, FirstName = "emre", LastName = "ozturk" });
        Console.WriteLine(result.Message);
    }

    private static void CarTest()
    {
        CarManager carManager = new CarManager(new EfCarDal());

        var result = carManager.Add(new Car { CarName = "a", BrandId = 414, ColorId = 323, ModelYear = 2022, DailyPrice = 400, Description = "otomatik" });
        Console.WriteLine(result.Message);

        foreach (var c in carManager.GetCarDetails().Data)
        {
            Console.WriteLine(c.DailyPrice + " >> " + c.BrandName + " >> " + c.ColorId);
        }




    }

    private static void BrandTest()
    {
        BrandManager brandManager = new BrandManager(new EfBrandDal());
        var result = brandManager.GetAll();

        if (result.Success)
        {
            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine(result.Message);
        }
        else
        {
            Console.WriteLine(result.Message);
        }
    }

    private static void ColorTest()
    {
        ColorManager colorManager = new ColorManager(new EfColorDal());
        var result = colorManager.GetAll();

        if (result.Success)
        {
            foreach (var color in result.Data)
            {
                Console.WriteLine(color.ColorName);
            }
            Console.WriteLine(result.Message);
        }
        else
        {
            Console.WriteLine(result.Message);
        }
    }
}

    



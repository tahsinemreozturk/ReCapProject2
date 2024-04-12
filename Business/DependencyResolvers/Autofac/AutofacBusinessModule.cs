using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();
            builder.RegisterType<CarImageManager>().As<ICarImageService>().SingleInstance();
            
            builder.RegisterType<FileHelperManager>().As<IFileHelper>().SingleInstance();

            builder.RegisterType<EfCarDal>().As<ICarDal>().SingleInstance();
            builder.RegisterType<EfCarImageDal>().As<ICarImageDal>().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance(); 
            builder.RegisterType<JwtHelper>().As<ITokenHelper>().SingleInstance();  
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();      
           

            // AOP entegrasyonu
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            // bütün sınıflar metodlar çağrılmadan önce autofac aspect'leri var mı diye kontrol ediyor.
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new Castle.DynamicProxy.ProxyGenerationOptions
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }

    }

}
    
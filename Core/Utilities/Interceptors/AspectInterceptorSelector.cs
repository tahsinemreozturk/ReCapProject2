using Castle.DynamicProxy;
using System.Reflection;

namespace Core.Utilities.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
                (true).ToList();
            var methodAttributes = type.GetMethod(method.Name)
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes);

            //classAttributes.Add(new ExceptionLogAspect(typeof(FileLogger)));

            //yukaridaki kod blogu => otomatik olarak sistemdeki butun metotlari log`a dahil et demektir.
            //Loglama altyapsini yazdiktan sonra bu kodu eklersek otomatik loglama sistemini eklemis oluruz.
            //boylece buyuk projelerde loglama yapilip yapilmadigi dertlerini azaltir ve yonetimi kolaylastirir.

            return classAttributes.OrderBy(x => x.Priority).ToArray();
        }
    }
}

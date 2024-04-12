using Business.Constants;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Core.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessAspects.Autofac
{
    public class SecuredOperation : MethodInterception
    {
        //SecuredOperation JWT icin.
        private string[] _roles;
        //IHttpContextAccessor HTTP isteğine erişim sağlamak ve bu isteğe ilişkin bilgileri almak için kullanılır.
        private IHttpContextAccessor _httpContextAccessor;

        public SecuredOperation(string roles)
        {
            //roles.Split ile bir metni benim belirtigim karaktere gore, ayirip array`e atiyoruz. Attiributte kullanimi icin bu gereklidir.
            _roles = roles.Split(',');
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();

        }

        protected override void OnBefore(IInvocation invocation)
        {
            // Kullanıcının claimlerini bulmasını sağlar.
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
            //rolleri gez ve eğer claimlerinin içinde ilgili rol varsa metodu çalıştırmaya devam et.
            foreach (var role in _roles)
            {
                if (roleClaims.Contains(role))
                {
                    return;
                }
            }
            //yetkisi yoksa hata ver.
            throw new Exception(Messages.AuthorizationDenied);
        }
    }
}

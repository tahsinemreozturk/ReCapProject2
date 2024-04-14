using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection serviceColleciton, ICoreModule[] modules)
        {
            foreach (var module in modules) 
            {
                module.Load(serviceColleciton);
            }
            return ServiceTool.Create(serviceColleciton);
        }
    }
}

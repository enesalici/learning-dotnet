﻿using Business.Abstracts;
using Business.Concrates;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Business
{
    public static class BusinessServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(config => {
                config.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
            });


            return services;
        }
    }
}
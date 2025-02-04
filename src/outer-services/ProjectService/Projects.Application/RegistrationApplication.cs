﻿using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Projects.Application
{
    public static class RegistrationApplication
    {
        public static IServiceCollection AddMediatRServices(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg
            .RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            return services;
        }
        public static IServiceCollection AddMapperServices(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg => cfg.AddMaps(Assembly.GetExecutingAssembly()));

            return services;
        }
    }
}

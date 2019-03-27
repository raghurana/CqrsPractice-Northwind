using System;
using System.Reflection;
using AutoMapper;
using CqrsPractice.Application.Customers.Queries.CustomerList;
using CqrsPractice.Application.Infrastructure;
using CqrsPractice.WebApi.DependencyInjection;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace CqrsPractice.WebApi   
{
    public class Startup
    {
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services
                .AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services
                .AddAutoMapper(typeof(AutoMapperProfile).GetTypeInfo().Assembly);

            services
                .AddMediatR(typeof(CustomerListQueryHandler).GetTypeInfo().Assembly);

            return services.AddAutofacAsDependencyProvider();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseHsts();

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}

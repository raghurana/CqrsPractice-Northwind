using System;
using System.Linq;
using System.Reflection;
using AutoMapper;

namespace CqrsPractice.Application.Infrastructure
{
    public interface IHaveCustomMapping
    {
        void CreateMappings(Profile configuration);
    }

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            LoadCustomMappings();
        }

        private void LoadCustomMappings()
        {
            var types = Assembly.GetExecutingAssembly().GetExportedTypes();

            var mapsFrom = (
                from type in types
                from instance in type.GetInterfaces()
                where
                    typeof(IHaveCustomMapping).IsAssignableFrom(type) &&
                    !type.IsAbstract &&
                    !type.IsInterface
                select (IHaveCustomMapping) Activator.CreateInstance(type)).ToList();

            foreach (var map in mapsFrom)
            {
                map.CreateMappings(this);
            }
        }
    }
}
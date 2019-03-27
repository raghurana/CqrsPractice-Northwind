using AutoMapper;
using CqrsPractice.Application.Infrastructure;
using CqrsPractice.Domain.Entities;

namespace CqrsPractice.Application.Customers.Queries.CustomerList
{
    public class CustomerListItemModel : IHaveCustomMapping
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Customer, CustomerListItemModel>()
                .ForMember(model => model.Id,   opt => opt.MapFrom(c => c.CustomerId))
                .ForMember(model => model.Name, opt => opt.MapFrom(c => c.CompanyName));
        }
    }
}
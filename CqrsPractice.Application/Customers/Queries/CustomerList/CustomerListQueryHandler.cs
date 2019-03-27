using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CqrsPractice.Domain.Entities;
using MediatR;

namespace CqrsPractice.Application.Customers.Queries.CustomerList
{
    public class CustomerListQueryHandler : IRequestHandler<CustomerListQuery, CustomerListModel>
    {
        private readonly IMapper mapper;

        public CustomerListQueryHandler(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public Task<CustomerListModel> Handle(CustomerListQuery request, CancellationToken cancellationToken)
        {
            var dbCustomers = new List<Customer>
            {
                new Customer {CustomerId = "1", CompanyName = "Kichoo Productions"},
                new Customer {CustomerId = "2", CompanyName = "Geezo Productions"}
            };

            return Task.FromResult(new CustomerListModel
            {
                Customers = mapper.Map<List<CustomerListItemModel>>(dbCustomers)
            });
        }
    }
}
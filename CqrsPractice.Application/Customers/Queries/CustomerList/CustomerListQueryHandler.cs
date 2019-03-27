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
            var databaseCustomer = new Customer {CustomerId = "1", CompanyName = "Kichoo Productions"};

            return Task.FromResult(new CustomerListModel
            {
                Customers = new List<CustomerListItemModel>
                {
                    mapper.Map<CustomerListItemModel>(databaseCustomer)
                }
            });
        }
    }
}
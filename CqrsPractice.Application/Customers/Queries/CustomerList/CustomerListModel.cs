using System.Collections;
using System.Collections.Generic;

namespace CqrsPractice.Application.Customers.Queries.CustomerList
{
    public class CustomerListModel
    {
        public IList<CustomerListItemModel> Customers { get; set; }
    }
}
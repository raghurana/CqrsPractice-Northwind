using System.Threading.Tasks;
using CqrsPractice.Application.Customers.Queries.CustomerList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CqrsPractice.WebApi.Controllers
{
    [Route(ApiRoutes.CustomersV1)]
    public class CustomersController : BaseController
    {
        private readonly IMediator mediator;

        public CustomersController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<CustomerListModel>> GetAll()
        {
            var list = await mediator.Send(new CustomerListQuery());
            return Ok(list);
        }
    }
}
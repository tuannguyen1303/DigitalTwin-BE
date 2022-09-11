using DigitalTwin.Models.Requests.Product;
using DigitalTwin.Models.Responses;
using DigitalTwin.Models.Responses.Product;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DigitalTwin.Api.Controllers
{
    public class ProductController : BaseController
    {
        public ProductController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<Response<List<ProductResponse>>> GetAll([FromBody] GetAllProductRequest request,
            CancellationToken token)
        {
            var result = await _mediator.Send(request, token);
            return result;
        }

        [HttpPost]
        public async Task<Response<ProductResponse>> CreateNewProduct([FromBody] CreateProductRequest request,
            CancellationToken token)
        {
            var result = await _mediator.Send(request, token);
            return result;
        }
    }
}
using MediatR;

namespace DigitalTwin.Api.Controllers
{
    public class ProductController : BaseController
    {
        public ProductController(IMediator mediator) : base(mediator)
        {
        }
    }
}

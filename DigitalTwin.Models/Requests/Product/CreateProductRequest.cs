using DigitalTwin.Models.Responses;
using DigitalTwin.Models.Responses.Product;
using MediatR;

namespace DigitalTwin.Models.Requests.Product;

public class CreateProductRequest : BaseRequest, IRequest<Response<ProductResponse>>
{
    public string Name { get; set; }
}
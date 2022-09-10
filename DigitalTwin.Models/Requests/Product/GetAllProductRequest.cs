using DigitalTwin.Models.Responses;
using DigitalTwin.Models.Responses.Product;
using MediatR;

namespace DigitalTwin.Models.Requests.Product;

public class GetAllProductRequest : BaseRequest, IRequest<Response<List<GetAllProductResponse>>>
{
    
}
using DigitalTwin.Business.Services.Product;
using DigitalTwin.Models.Requests.Product;
using DigitalTwin.Models.Responses;
using DigitalTwin.Models.Responses.Product;
using MediatR;

namespace DigitalTwin.Business.Handlers.Product.Queries;

public class GetAllProductQuery : IRequestHandler<GetAllProductRequest, Response<List<ProductResponse>>>
{
    private readonly IProductService _productService;

    public GetAllProductQuery(IProductService productService)
    {
        _productService = productService;
    }

    public async Task<Response<List<ProductResponse>>> Handle(GetAllProductRequest request, CancellationToken cancellationToken)
    {
        return await _productService.GetAllProduct(request, cancellationToken);
    }
}
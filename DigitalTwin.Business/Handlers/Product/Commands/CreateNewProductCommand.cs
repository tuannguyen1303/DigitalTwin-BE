using DigitalTwin.Business.Services.Product;
using DigitalTwin.Models.Requests.Product;
using DigitalTwin.Models.Responses;
using DigitalTwin.Models.Responses.Product;
using MediatR;

namespace DigitalTwin.Business.Handlers.Product.Commands;

public class CreateNewProductCommand : IRequestHandler<CreateProductRequest, Response<ProductResponse>>
{
    private readonly IProductService _productService;

    public CreateNewProductCommand(IProductService productService)
    {
        _productService = productService;
    }

    public async Task<Response<ProductResponse>> Handle(CreateProductRequest request,
        CancellationToken cancellationToken)
    {
        return await _productService.CreateNewProduct(request, cancellationToken);
    }
}
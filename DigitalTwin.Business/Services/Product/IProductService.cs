using DigitalTwin.Models.Requests.Product;
using DigitalTwin.Models.Responses;
using DigitalTwin.Models.Responses.Product;

namespace DigitalTwin.Business.Services.Product;

public interface IProductService
{
    Task<Response<List<ProductResponse>>> GetAllProduct(GetAllProductRequest request,
        CancellationToken token = default);

    Task<Response<ProductResponse>> CreateNewProduct(CreateProductRequest request, CancellationToken token = default);
}
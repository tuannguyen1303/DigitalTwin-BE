using DigitalTwin.Models.Requests.Product;
using DigitalTwin.Models.Responses;
using DigitalTwin.Models.Responses.Product;

namespace DigitalTwin.Business.Services.Product;

public interface IProductService
{
    Task<Response<List<GetAllProductResponse>>> GetAllProduct(GetAllProductRequest request, CancellationToken token = default);
}
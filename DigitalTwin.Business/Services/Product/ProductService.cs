using System.Net;
using DigitalTwin.Common.Exceptions;
using DigitalTwin.Models.Requests.Product;
using DigitalTwin.Models.Responses;
using DigitalTwin.Models.Responses.Product;

namespace DigitalTwin.Business.Services.Product;

public class ProductService : IProductService
{
    // adding db context
    public ProductService()
    {
    }

    public Task<Response<List<GetAllProductResponse>>> GetAllProduct(GetAllProductRequest request,
        CancellationToken token = default)
    {
        ResponseException.Throw((int)HttpStatusCode.BadRequest, "Exception Text Sample", "Exception Error Message",
            null);
        
        var result = new List<GetAllProductResponse>
        {
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Book"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Clothes"
            },
        };
        
        return Task.FromResult(Response.CreateResponse(result));
    }
}
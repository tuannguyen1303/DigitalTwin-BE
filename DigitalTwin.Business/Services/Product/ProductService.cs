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

    public Task<Response<List<ProductResponse>>> GetAllProduct(GetAllProductRequest request,
        CancellationToken token = default)
    {
        // Throws exception if something's wrong in request
        // ResponseException.Throw((int)HttpStatusCode.BadRequest, "Exception Text Sample", "Exception Error Message",
        //     null);
        
        var result = new List<ProductResponse>
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

    public Task<Response<ProductResponse>> CreateNewProduct(CreateProductRequest request, CancellationToken token = default)
    {
        var newProduct = new ProductResponse
        {
            Id = Guid.NewGuid(),
            Name = request.Name
        };
        
        return Task.FromResult(Response.CreateResponse(newProduct));
    }
}
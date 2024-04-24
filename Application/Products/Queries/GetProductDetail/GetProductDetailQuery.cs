using MediatR;
using Northwind.Application.Products.Queries.GetProductDetail;

namespace Application.Products.Queries.GetProductDetail;
public class GetProductDetailQuery : IRequest<ProductDetailVm>
{
    public int Id { get; set; }
}

using MediatR;
using Northwind.Application.Products.Queries.GetProductsList;

namespace Application.Products.Queries.GetProductsList;
public class GetProductsListQuery : IRequest<ProductsListVm>
{
}

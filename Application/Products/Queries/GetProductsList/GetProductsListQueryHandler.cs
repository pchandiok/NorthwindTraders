using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Application.Common.Interfaces;
using Application.Products.Queries.GetProductDetail;
using Northwind.Application.Products.Queries.GetProductsList;

namespace Application.Products.Queries.GetProductsList;
public class GetProductsListQueryHandler : IRequestHandler<GetProductsListQuery, ProductsListVm>
{
    private readonly INorthwindDbContext _context;
    private readonly IMapper _mapper;

    public GetProductsListQueryHandler(INorthwindDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<ProductsListVm> Handle(GetProductsListQuery request, CancellationToken cancellationToken)
    {
        var products = await _context.Products
            .ProjectTo<ProductDto>(_mapper.ConfigurationProvider)
            .OrderBy(p => p.ProductName)
            .ToListAsync(cancellationToken);

        var vm = new ProductsListVm
        {
            Products = products,
            CreateEnabled = true // TODO: Set based on user permissions.
        };

        return vm;
    }
}

using MediatR;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace Application.Categories.Queries.GetCategoriesList;

public class GetCategoriesListQueryHandler : IRequestHandler<GetCategoriesListQuery, CategoriesListVM>
{
    private readonly INorthwindDbContext _context;
    private readonly IMapper _mapper;

    public GetCategoriesListQueryHandler(INorthwindDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<CategoriesListVM> Handle(GetCategoriesListQuery request, CancellationToken cancellationToken)
    {
        var categories = await _context.Categories
            .ProjectTo<CategoryDto>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);

        var vm = new CategoriesListVM
        {
            Categories = categories,
            Count = categories.Count
        };

        return vm;
    }
}

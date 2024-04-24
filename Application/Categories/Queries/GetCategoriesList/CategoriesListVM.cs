namespace Application.Categories.Queries.GetCategoriesList;

public class CategoriesListVM
{
    public IList<CategoryDto> Categories { get; set; }
    public int Count { get; set; }
}


namespace Models.Entities;
public class Category
{
    public Category()
    {
        Products = new HashSet<Product>();
    }
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
    public string Description { get; set; }
    public byte[] Picture { get; set; }

    public ICollection<Product> Products { get; private set; }
}

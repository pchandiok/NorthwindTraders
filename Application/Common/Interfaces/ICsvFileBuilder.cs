using Application.Products.Queries.GetProductsFile;

namespace Application.Common.Interfaces;
public interface ICsvFileBuilder
{
    byte[] BuildProductsFile(IEnumerable<ProductRecordDto> records);
}

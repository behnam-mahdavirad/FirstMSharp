using MSharp;

namespace Domain
{
    public class ProductCategory : EntityType
    {
        public ProductCategory()
        {
            Name("Product Category");

            String("Name").Mandatory();
        }
    }
}
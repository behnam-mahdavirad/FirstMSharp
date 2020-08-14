using MSharp;

namespace Domain
{
    public class Product : EntityType
    {
        public Product()
        {
            String("Product name").Mandatory();

            Associate<ProductCategory>("Category").Mandatory();

            Associate<Supplier>("Suuplier").Mandatory();
        }
    }
}
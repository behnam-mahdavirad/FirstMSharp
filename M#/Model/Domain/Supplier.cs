using MSharp;

namespace Domain
{
    public class Supplier : EntityType
    {
        public Supplier()
        {
            String("Company name");
            String("Address");
        }
    }
}
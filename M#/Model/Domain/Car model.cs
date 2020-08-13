using MSharp;

namespace Domain
{
    public class CarModel : EntityType
    {
        public CarModel()
        {
            Associate<Manufacturer>("Manufacturer").Mandatory();
            String("Name").Mandatory();
        }
    }
}
using MSharp;

namespace Domain
{
    class CarModel : EntityType
    {
        public CarModel()
        {
            Associate<Manufacturer>("Manufacturer").Mandatory();
            String("Name").Mandatory();
        }
    }
}
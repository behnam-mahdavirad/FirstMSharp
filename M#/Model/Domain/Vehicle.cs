using MSharp;

namespace Domain
{
    public class Vehicle : EntityType
    {
        public Vehicle()
        {
            String("Make").Mandatory();
            String("Model").Mandatory();
            Int("Registration number").Mandatory();
        }
    }
}
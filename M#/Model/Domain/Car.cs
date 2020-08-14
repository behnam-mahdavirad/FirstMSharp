using MSharp;

namespace Domain
{
    public class Car : SubType<Vehicle>
    {
        public Car()
        {
            Int("Number of doors").Min(3).Max(5).Mandatory();
        }
    }
}

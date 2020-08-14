using MSharp;

namespace Domain
{
    public class Bike : SubType<Vehicle>
    {
        public Bike()
        {
            Bool("Required license").Mandatory();
        }
    }
}

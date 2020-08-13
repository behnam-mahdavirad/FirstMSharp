using MSharp;

namespace Domain
{
    public class Customer : EntityType
    {
        public Customer()
        {
            Associate<Country>("Country");

            String("Company name").Mandatory(value: false);
            Date("Contract start date").Mandatory(value: false);
            OpenImage("Logo").Width(200).Height(80).Mandatory(value: false);
            OpenFile("Contract").Mandatory(value: false);
        }
    }
}
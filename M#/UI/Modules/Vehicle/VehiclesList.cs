using MSharp;

namespace Modules
{
    public class VehiclesList : ListModule<Domain.Vehicle>
    {
        public VehiclesList()
        {
            HeaderText("Vehicles");

            ShowHeaderRow();

            Column(x => x.Make);
            Column(x => x.Model);
        }
    }
}
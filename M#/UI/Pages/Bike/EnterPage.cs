using MSharp;

namespace Bike
{
    public class EnterPage : SubPage<BikePage>
    {
        public EnterPage()
        {
            Add<Modules.BikeForm>();
        }
    }
}

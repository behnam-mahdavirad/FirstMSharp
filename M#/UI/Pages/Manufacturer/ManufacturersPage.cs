using MSharp;

namespace UI.Pages.Manufacturer
{
    public class ManufacturersPage : SubPage<ManufacturerPage>
    {
        public ManufacturersPage()
        {
            Add<Modules.ManufacturersList>();
        }
    }
}

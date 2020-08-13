using MSharp;

namespace UI.Pages
{
    public class ManufacturerPage : RootPage
    {
        public ManufacturerPage()
        {
            Add<Modules.AdminSettingsMenu>();

            OnStart(x => x.Go<Manufacturer.ManufacturersPage>().RunServerSide());
        }
    }
}

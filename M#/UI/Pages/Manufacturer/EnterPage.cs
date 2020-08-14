using MSharp;

namespace UI.Pages.Manufacturer
{
    public class EnterPage : SubPage<ManufacturerPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Add<Modules.ManufacturerAdd>();
        }
    }
}

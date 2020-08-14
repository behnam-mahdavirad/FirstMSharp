using MSharp;

namespace UI.Pages.Manufacturer
{
    public class EditPage : SubPage<ManufacturerPage>
    {
        public EditPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.ManufacturerEdit>();
        }
    }
}

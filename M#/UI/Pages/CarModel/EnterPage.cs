using MSharp;

namespace UI.Pages.CarModel
{
    public class EnterPage : SubPage<CarModelPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.CarModelForm>();
        }
    }
}

using MSharp;

namespace UI.Pages
{
    public class CarModelPage : RootPage
    {
        public CarModelPage()
        {
            Add<Modules.AdminSettingsMenu>();
            Add<Modules.MainMenu>();

            OnStart(x => x.Go<CarModel.CarModelsPage>().RunServerSide());
        }
    }
}

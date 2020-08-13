using MSharp;

namespace UI.Pages.CarModel
{
    public class CarModelsPage : SubPage<CarModelPage>
    {
        public CarModelsPage()
        {
            Add<Modules.CarModelsList>();
        }
    }
}

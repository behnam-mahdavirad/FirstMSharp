using MSharp;

namespace Car
{
    public class EnterPage : SubPage<CarPage>
    {
        public EnterPage()
        {
            Add<Modules.CarForm>();
        }
    }
}

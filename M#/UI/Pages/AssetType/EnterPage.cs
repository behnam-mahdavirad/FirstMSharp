using MSharp;

namespace UI.Pages.AssetType
{
    public class EnterPage : SubPage<AssetTypePage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.AssetTypeForm>();
        }
    }
}

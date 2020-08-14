using MSharp;

namespace UI.Pages.Owner
{
    public class EnterPage : SubPage<OwnerPage>
    {
        public EnterPage()
        {
            Add<Modules.OwnerForm>();
        }
    }
}

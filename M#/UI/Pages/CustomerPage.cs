using MSharp;

namespace UI.Pages
{
    public class CustomerPage : RootPage
    {
        public CustomerPage()
        {
            Add<Modules.AdminSettingsMenu>();

            OnStart(x => x.Go<Customer.CustomersPage>().RunServerSide());
        }
    }
}

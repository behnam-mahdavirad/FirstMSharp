using MSharp;

namespace Admin.Settings
{
    public class AdministratorsPage : SubPage<SettingsPage>
    {
        public AdministratorsPage()
        {
            Add<Modules.AdministratorsList>();
        }
    }
}
using MSharp;

namespace Admin
{
    public class SettingsPage : SubPage<AdminPage>
    {
        public SettingsPage()
        {
            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            OnStart(x => x.Go<Settings.GeneralPage>().RunServerSide());
        }
    }
}
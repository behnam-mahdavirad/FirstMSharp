using MSharp;

namespace Admin.Settings
{
    public class ContentBlocksPage : SubPage<SettingsPage>
    {
        public ContentBlocksPage()
        {
            Add<Modules.ContentBlocksList>();
        }
    }
}
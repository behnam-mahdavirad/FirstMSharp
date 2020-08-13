using Modules;
using MSharp;

namespace UI.Pages.Project
{
    public class EditPage : SubPage<ProjectPage>
    {
        public EditPage()
        {
            Layout(Layouts.AdminDefault);

            Add<ProjectEdit>();
        }
    }
}

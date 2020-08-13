using Modules;
using MSharp;

namespace UI.Pages.Project
{
    public class EnterPage : SubPage<ProjectPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Add<ProjectAdd>();
        }
    }
}

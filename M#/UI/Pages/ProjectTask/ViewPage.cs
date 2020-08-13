using MSharp;

namespace UI.Pages.ProjectTask
{
    public class ViewPage : SubPage<ProjectTaskPage>
    {
        public ViewPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.ProjectTaskView>();
        }
    }
}

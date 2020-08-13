using MSharp;

namespace UI.Pages.ProjectTask
{
    public class EditPage : SubPage<ProjectTaskPage>
    {
        public EditPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Add<Modules.ProjectTaskEdit>();
        }
    }
}

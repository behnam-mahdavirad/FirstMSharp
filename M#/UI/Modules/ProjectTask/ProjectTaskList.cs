using MSharp;
using UI.Pages.ProjectTask;

namespace Modules
{
    public class ProjectTaskList : ListModule<Domain.ProjectTask>
    {
        public ProjectTaskList()
        {
            ShowFooterRow()
                .ShowHeaderRow()
                .UseDatabasePaging(false)
                .HeaderText("Tasks")
                .PageSize(10);

            LinkColumn("view").HeaderText("view")
                .OnClick(x => x.Go<ViewPage>()
                .Send("item", "item.ID")
                .SendReturnUrl());

            Column(x => x.Project);
            Column(x => x.Title);
            Column(x => x.Description);
            Column(x => x.Done).LabelText("Is done?");

            ButtonColumn("Edit").HeaderText("Edit").Icon(FA.Edit)
                .OnClick(x => x.PopUp<EditPage>()
                .Send("item", "item.ID")
                .SendReturnUrl(false));

            ButtonColumn("Delete")
                .HeaderText("Delete")
                .ConfirmQuestion("Are you sure you want to delete this Task?")
                .CssClass("btn-danger")
                .Icon(FA.Remove)
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.Reload();
                });

            Button("New Project Task").Icon(FA.Plus)
                /*M#:w[42]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page uses ReturnUrl which is not provided.*/.OnClick(x => x.Go<EnterPage>());
        }
    }
}

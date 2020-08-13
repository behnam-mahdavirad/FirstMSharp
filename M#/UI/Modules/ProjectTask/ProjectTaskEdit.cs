using MSharp;

namespace Modules
{
    public class ProjectTaskEdit : FormModule<Domain.ProjectTask>
    {
        /*M#:w[6]T-Prop:SupportsAdd-Type:FormModule-All links to this page seem to pass the ProjectTask ID. So this form appears to be used for 'Edit' only. In that case, set 'SupportsAdd' to 'false' to prevent errors or security breach.*/public ProjectTaskEdit()
        {
            HeaderText("Task details");

            Field(x => x.Done).Control(ControlType.CheckBox).Label("Done?");
            Field(x => x.Title).Mandatory();
            Field(x => x.Description).Control(ControlType.Textbox).NumberOfLines(5);

            Button("Cancel").OnClick(x => x.CloseModal());

            Button("Save").IsDefault().Icon(FA.Check)
            .OnClick(x =>
            {
                x.SaveInDatabase();
                x.GentleMessage("Saved successfully.");
                x.CloseModal();
            });
        }
    }
}

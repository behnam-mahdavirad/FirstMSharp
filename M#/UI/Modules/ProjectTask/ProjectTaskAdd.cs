using MSharp;

namespace Modules
{
    public class ProjectTaskAdd : FormModule<Domain.ProjectTask>
    {
        /*M#:w[6]T-Prop:SupportsEdit-Type:FormModule-No page linking to this page seem to pass the ProjectTask ID. So this form appears to be used for 'Insert' only, while it allows editing. In that case, set 'SupportsEdit' to 'false' to prevent errors or security breach.*/public ProjectTaskAdd()
        {
            HeaderText("Task details");

            Field(x => x.Project).Control(ControlType.DropdownList);
            Field(x => x.Title).Mandatory();
            Field(x => x.Description).Control(ControlType.Textbox).NumberOfLines(5);

            Button("Cancel").OnClick(x => x.ReturnToPreviousPage());

            Button("Save").IsDefault().Icon(FA.Check)
            .OnClick(x =>
            {
                x.SaveInDatabase();
                x.GentleMessage("Saved successfully.");
                x.ReturnToPreviousPage();
            });
        }
    }
}

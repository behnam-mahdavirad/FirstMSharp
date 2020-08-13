using MSharp;

namespace Modules
{
    public class ProjectEdit : FormModule<Domain.Project>
    {
        /*M#:w[6]T-Prop:SupportsAdd-Type:FormModule-All links to this page seem to pass the Project ID. So this form appears to be used for 'Edit' only. In that case, set 'SupportsAdd' to 'false' to prevent errors or security breach.*/public ProjectEdit()
        {
            HeaderText("Project details");

            Field(x => x.Name);

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

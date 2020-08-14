using MSharp;

namespace Modules
{
    public class ManufacturerEdit : FormModule<Domain.Manufacturer>
    {
        /*M#:w[6]T-Prop:SupportsAdd-Type:FormModule-All links to this page seem to pass the Manufacturer ID. So this form appears to be used for 'Edit' only. In that case, set 'SupportsAdd' to 'false' to prevent errors or security breach.*/public ManufacturerEdit()
        {
            HeaderText("Manufacturer details");

            Field(x => x.Name);

            Button("Cancel").OnClick(x => x.ReturnToPreviousPage());

            Button("Save").IsDefault()
            .OnClick(x =>
            {
                x.SaveInDatabase();
                x.GentleMessage("Saved successfully.");
                x.ReturnToPreviousPage();
            });
        }
    }
}

using MSharp;

namespace Modules
{
    public class ManufacturerAdd : FormModule<Domain.Manufacturer>
    {
        /*M#:w[6]T-Prop:SupportsEdit-Type:FormModule-No page linking to this page seem to pass the Manufacturer ID. So this form appears to be used for 'Insert' only, while it allows editing. In that case, set 'SupportsEdit' to 'false' to prevent errors or security breach.*/public ManufacturerAdd()
        {
            HeaderText("Manufacturer details");

            Field(x => x.Name);

            Button("Cancel").OnClick(x => x.CloseModal());

            Button("Save").IsDefault()
            .OnClick(x =>
            {
                x.SaveInDatabase();
                x.GentleMessage("Saved successfully.");
                x.CloseModal(Refresh.Full);
            });
        }
    }
}

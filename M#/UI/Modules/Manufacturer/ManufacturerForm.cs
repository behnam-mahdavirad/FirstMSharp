using MSharp;

namespace Modules
{
    public class ManufacturerForm : FormModule<Domain.Manufacturer>
    {
        public ManufacturerForm()
        {
            HeaderText("Manufacturer details");

            Field(x => x.Name).Control(ControlType.Textbox).Mandatory();

            Button("Cancel").OnClick(x => x.CloseModal());

            Button("Save").IsDefault()
            .OnClick(x =>
            {
                x.SaveInDatabase();
                x.GentleMessage("Saved successfully.");
                x.CloseModal();
            });
        }
    }
}
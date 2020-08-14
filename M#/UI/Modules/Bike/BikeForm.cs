using MSharp;

namespace Modules
{
    public class BikeForm : FormModule<Domain.Bike>
    {
        public BikeForm()
        {
            HeaderText("Bike details");

            Field(x => x.Make);

            Field(x => x.Model);

            Field(x => x.RegistrationNumber);

            Field(x => x.RequiredLicense).Control(ControlType.CheckBox);

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
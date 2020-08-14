using MSharp;

namespace Modules
{
    public class CarForm : FormModule<Domain.Car>
    {
        public CarForm()
        {
            HeaderText("Car details");

            Field(x => x.Make);

            Field(x => x.Model);

            Field(x => x.RegistrationNumber);

            Field(x => x.NumberOfDoors).Control(ControlType.HorizontalRadioButtons);

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
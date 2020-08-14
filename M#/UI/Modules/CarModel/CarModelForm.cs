using MSharp;

namespace Modules
{
    class CarModelForm : FormModule<Domain.CarModel>
    {
        public CarModelForm()
        {
            HeaderText("Add/Edit Car model");

            Field(x => x.Manufacturer).Control(ControlType.DropdownList).Mandatory();
            Field(x => x.Name).Mandatory();

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
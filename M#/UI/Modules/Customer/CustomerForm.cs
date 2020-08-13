using MSharp;

namespace Modules
{
    class CustomerForm : FormModule<Domain.Customer>
    {
        public CustomerForm()
        {
            Field(x => x.Country).Control(ControlType.DropdownList);
            Field(x => x.CompanyName);
            Field(x => x.Logo).Control(ControlType.FileUpload).Mandatory(value: false);
            Field(x => x.Contract).Control(ControlType.FileUpload).Mandatory(value: false);
            Field(x => x.ContractStartDate).Control(ControlType.DateAndTimePicker);

            Button("Cancel").CausesValidation(false).Icon(FA.Backward)
                .OnClick(x => x.CloseModal());

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
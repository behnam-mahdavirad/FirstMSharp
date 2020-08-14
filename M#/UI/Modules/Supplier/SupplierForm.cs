using MSharp;

namespace Modules
{
    public class SupplierForm : FormModule<Domain.Supplier>
    {
        public SupplierForm()
        {
            HeaderText("Add/Edit Supplier");

            Field(x => x.CompanyName);
            Field(x => x.Address).NumberOfLines(5);

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
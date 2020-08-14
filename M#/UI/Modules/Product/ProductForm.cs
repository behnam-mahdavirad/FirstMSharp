using MSharp;

namespace Modules
{
    class ProductForm : FormModule<Domain.Product>
    {
        public ProductForm()
        {
            HeaderText("Product details");

            Field(x => x.ProductName);
            Field(x => x.Category).Control(ControlType.DropdownList);
            Field(x => x.Supplier).Control(ControlType.DropdownList);

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
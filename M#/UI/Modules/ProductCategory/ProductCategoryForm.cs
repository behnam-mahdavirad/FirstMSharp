using MSharp;

namespace Modules
{
    public class ProductCategoryForm : FormModule<Domain.ProductCategory>
    {
        public ProductCategoryForm()
        {
            HeaderText("Add/Edit Product category");

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
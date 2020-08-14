using MSharp;

namespace Modules
{
    public class ProductCategoriesList : ListModule<Domain.ProductCategory>
    {
        public ProductCategoriesList()
        {
            HeaderText("Product Categories");

            Search(GeneralSearch.AllFields).Label("Find:");

            Column(x => x.Name);

            ButtonColumn("Edit").HeaderText("Edit").GridColumnCssClass("actions").Icon(FA.Edit)
                /*M#:w[15]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page uses ReturnUrl which is not provided.*/.OnClick(x => x.Go<UI.Pages.ProductCategory.EnterPage>().Send("item", "item.ID"));

            ButtonColumn("Delete").HeaderText("Delete").Icon(FA.Remove).GridColumnCssClass("actions")
                .ConfirmQuestion("Are you sure you want to delete this product category?")
                .CssClass("btn-danger")
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.Reload();
                });

            Button("New Product Category").Icon(FA.Plus)
                /*M#:w[27]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page uses ReturnUrl which is not provided.*/.OnClick(x => x.Go<UI.Pages.ProductCategory.EnterPage>());
        }
    }
}

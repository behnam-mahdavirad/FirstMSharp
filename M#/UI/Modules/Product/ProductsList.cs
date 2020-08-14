using MSharp;

namespace Modules
{
    class ProductsList : ListModule<Domain.Product>
    {
        public ProductsList()
        {
            HeaderText("Products");

            Search(x => x.Supplier).Label("Supplier").Control(ControlType.DropdownList);
            Search(x => x.Category).Label("Category");
            /*M#:w[12]T-Prop:Workflow-Type:ModuleButton-A button must have some workflow (redirect, previous page, close modal, etc).*/SearchButton("Search");

            ButtonColumn("View").HeaderText("View").GridColumnCssClass("actions").Icon(FA.Search)
                .OnClick(x => x.PopUp<UI.Pages.Product.ViewPage>().Send("item", "item.ID"));

            Column(x => x.ProductName);
            Column(x => x.Category).LabelText("Category");
            Column(x => x.Supplier);

            ButtonColumn("Edit").HeaderText("Edit").GridColumnCssClass("actions").Icon(FA.Edit)
                /*M#:w[22]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page uses ReturnUrl which is not provided.*/.OnClick(x => x.Go<UI.Pages.Product.EnterPage>().Send("item", "item.ID"));

            ButtonColumn("Delete").HeaderText("Delete").GridColumnCssClass("actions").Icon(FA.Remove)
                .ConfirmQuestion("Are you sure you want to delete this Product?")
                .CssClass("btn-danger")
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.Reload();
                });

            Button("New Product").Icon(FA.Plus)
                /*M#:w[34]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page uses ReturnUrl which is not provided.*/.OnClick(x => x.Go<UI.Pages.Product.EnterPage>());
        }
    }
}

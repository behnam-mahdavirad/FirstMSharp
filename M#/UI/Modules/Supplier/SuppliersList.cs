using MSharp;

namespace Modules
{
    public class SuppliersList : ListModule<Domain.Supplier>
    {
        public SuppliersList()
        {
            HeaderText("Suppliers");

            Search(GeneralSearch.AllFields).Label("Find:");

            Column(x => x.CompanyName);
            Column(x => x.Address);

            ButtonColumn("Edit").HeaderText("Edit").GridColumnCssClass("actions").Icon(FA.Edit)
                /*M#:w[16]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page uses ReturnUrl which is not provided.*/.OnClick(x => x.Go<UI.Pages.Supplier.EnterPage>().Send("item", "item.ID"));

            ButtonColumn("Delete").HeaderText("Delete").GridColumnCssClass("actions").Icon(FA.Remove)
                .ConfirmQuestion("Are you sure you want to delete this Supplier?")
                .CssClass("btn-danger")
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.Reload();
                });

            Button("Add New").Icon(FA.Plus)
                /*M#:w[28]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page uses ReturnUrl which is not provided.*/.OnClick(x => x.Go<UI.Pages.Supplier.EnterPage>());
        }
    }
}

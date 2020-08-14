using MSharp;

namespace Modules
{
    public class ManufacturersList : ListModule<Domain.Manufacturer>
    {
        public ManufacturersList()
        {
            HeaderText("Manufacturers");

            Column(x => x.Name);

            ButtonColumn("Edit").HeaderText("Edit").GridColumnCssClass("actions").Icon(FA.Edit)
                /*M#:w[13]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page uses ReturnUrl which is not provided.*/.OnClick(x => x.Go<UI.Pages.Manufacturer.EditPage>()
                .Send("item", "item.ID").SendReturnUrl(false));

            ButtonColumn("Delete").HeaderText("Delete").GridColumnCssClass("actions").Icon(FA.Remove)
                .ConfirmQuestion("Are you sure you want to delete this manufacturer?")
                .CssClass("btn-danger")
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.Reload();
                });

            Button("Add Manufacturer")
                .OnClick(x => x.PopUp<UI.Pages.Manufacturer.EnterPage>()
                .SendReturnUrl(false));
        }
    }
}

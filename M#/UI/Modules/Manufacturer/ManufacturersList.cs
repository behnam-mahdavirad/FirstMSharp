using MSharp;

namespace Modules
{
    public class ManufacturersList : ListModule<Domain.Manufacturer>
    {
        public ManufacturersList()
        {
            Column(x => x.Name);

            ButtonColumn("Edit").HeaderText("Actions").GridColumnCssClass("actions").Icon(FA.Edit)
                /*M#:w[11]T-Prop:Target-Type:NavigateActivity-Redirect from non-modal to modal with bad «target»: Page [Manufacturer > Manufacturers] -> Module [ManufacturersList] -> [[ManufacturersList].Edit] -> Target page : [Manufacturer > Manufacturers > Enter]*/.OnClick(x => x.Go<UI.Pages.Manufacturer.EnterPage>()
                .Send("item", "item.ID").SendReturnUrl(false));

            ButtonColumn("Delete").HeaderText("Actions").GridColumnCssClass("actions").Icon(FA.Remove)
                .ConfirmQuestion("Are you sure you want to delete this manufacturer?")
                .CssClass("btn-danger")
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.RefreshPage();
                });

            Button("New Manufacturer")
                .OnClick(x => x.PopUp<UI.Pages.Manufacturer.EnterPage>());
        }
    }
}

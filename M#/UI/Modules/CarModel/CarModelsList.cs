using MSharp;

namespace Modules
{
    public class CarModelsList : ListModule<Domain.CarModel>
    {
        
        public CarModelsList()
        {
            Field(x => x.Manufacturer);

            Field(x => x.Name);

            ButtonColumn("Edit").Icon(FA.Edit).HeaderText("Actions").GridColumnCssClass("actions")
                /*M#:w[14]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page uses ReturnUrl which is not provided.*/.OnClick(x => x.Go<UI.Pages.CarModel.EnterPage>()
                .Send("item", "item.ID").SendReturnUrl(false));

            ButtonColumn("Delete").Icon(FA.Remove).HeaderText("Actions").GridColumnCssClass("actions")
                .ConfirmQuestion("Are you sure you want to delete this car model?")
                .CssClass("btn-danger")
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.RefreshPage();
                });

            Button("Add New")
                .Icon(FA.LongArrowRight)
                /*M#:w[28]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page uses ReturnUrl which is not provided.*/.OnClick(x => x.Go<UI.Pages.CarModel.EnterPage>()
                .SendReturnUrl(false));
        }
    }
}

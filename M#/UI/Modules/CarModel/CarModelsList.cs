using MSharp;

namespace Modules
{
    class CarModelsList : ListModule<Domain.CarModel>
    {
        public CarModelsList()
        {
            ShowFooterRow()
                 .ShowHeaderRow()
                 .UseDatabasePaging(false)
                 .HeaderText("Car models")
                 .PageSize(10);

            Column(x => x.Manufacturer);
            Column(x => x.Name);

            ButtonColumn("Edit").HeaderText("Edit").GridColumnCssClass("actions").Icon(FA.Edit)
                /*M#:w[18]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page uses ReturnUrl which is not provided.*/.OnClick(x => x.Go<UI.Pages.CarModel.EnterPage>().Send("item", "item.ID"));

            ButtonColumn("Delete").HeaderText("Delete").GridColumnCssClass("actions").Icon(FA.Remove)
                .ConfirmQuestion("Are you sure you want to delete this car model?")
                .CssClass("btn-danger")
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.Reload();
                });

            Button("Add New").Icon(FA.LongArrowRight)
                /*M#:w[30]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page uses ReturnUrl which is not provided.*/.OnClick(x => x.Go<UI.Pages.CarModel.EnterPage>());
        }
    }
}

using MSharp;

namespace Modules
{
    public class BikesList : ListModule<Domain.Bike>
    {
        public BikesList()
        {
            HeaderText("Bikes");

            ShowHeaderRow();

            Search(GeneralSearch.ClientSideFilter).Label("Filter:");

            Column(x => x.Make);

            Column(x => x.Model);

            Column(x => x.RegistrationNumber);

            Column(x => x.RequiredLicense);

            ButtonColumn("Edit").Icon(FA.Edit)
                .OnClick(x => x.Go<Bike.EnterPage>().Send("item", "item.ID").SendReturnUrl());

            ButtonColumn("Delete").Icon(FA.Remove)
                .HeaderText("Delete").GridColumnCssClass("actions")
                .ConfirmQuestion("Are you sure you want to delete this Bike?")
                .CssClass("btn-danger")
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.RefreshPage();
                });

            Button("Add Bike").Icon(FA.Plus)
                .OnClick(x => x.Go<Bike.EnterPage>().SendReturnUrl());
        }
    }
}
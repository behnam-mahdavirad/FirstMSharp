using MSharp;

namespace Modules
{
    public class CarsList : ListModule<Domain.Car>
    {
        public CarsList()
        {
            HeaderText("Cars");

            ShowHeaderRow();

            IndexColumn();

            Column(x => x.Make);

            Column(x => x.Model);

            Column(x => x.RegistrationNumber);

            Column(x => x.NumberOfDoors);

            ButtonColumn("Edit").Icon(FA.Edit)
                .OnClick(x => x.Go<Car.EnterPage>().Send("item", "item.ID").SendReturnUrl());

            ButtonColumn("Delete").Icon(FA.Remove)
                .HeaderText("Delete").GridColumnCssClass("actions")
                .ConfirmQuestion("Are you sure you want to delete this Car?")
                .CssClass("btn-danger")
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.RefreshPage();
                });

            Button("Export").Icon(FA.FileExcelO)
                .OnClick(x => x.Export(ExportFormat.Excel));

            Button("Add car").Icon(FA.Plus)
                .OnClick(x => x.Go<Car.EnterPage>().SendReturnUrl());
        }
    }
}
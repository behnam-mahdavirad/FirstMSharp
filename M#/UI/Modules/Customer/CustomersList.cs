using MSharp;

namespace Modules
{
    class CustomersList : ListModule<Domain.Customer>
    {
        public CustomersList()
        {
            Column(x => x.Country);
            Column(x => x.CompanyName);
            Column(x => x.ContractStartDate);
            Column(x => x.Logo);
            Column(x => x.Contract);

            ButtonColumn("Edit").Icon(FA.Edit)
                .OnClick(x => x.PopUp<UI.Pages.Customer.EnterPage>()
                .Send("item", "item.ID"));

            ButtonColumn("Delete").Icon(FA.Remove)
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.RefreshPage();
                });

            Button("New Customer").Icon(FA.Plus)
                .OnClick(x => x.PopUp<UI.Pages.Customer.EnterPage>());
        }
    }
}
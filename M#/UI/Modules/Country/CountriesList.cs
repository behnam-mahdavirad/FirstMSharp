using Domain;
using MSharp;

namespace Modules
{
    class CountriesList : ListModule<Domain.Country>
    {
        public CountriesList()
        {
            Column(x => x.Name);

            ButtonColumn("Edit").Icon(FA.Edit)
                .OnClick(x => x.PopUp<UI.Pages.Country.EnterPage>()
                .Send("item", "item.ID"));

            ButtonColumn("Delete").Icon(FA.Remove)
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.RefreshPage();
                });

            Button("New Country").Icon(FA.Plus)
                .OnClick(x => x.PopUp<UI.Pages.Country.EnterPage>());
        }
    }
}
using MSharp;

namespace Modules
{
    public class OwnersList : ListModule<Domain.Owner>
    {
        public OwnersList()
        {
            HeaderText("Owners");

            Column(x => x.FirstName);
            Column(x => x.LastName);

            ButtonColumn("Edit")
                .HeaderText("Edit")
                .GridColumnCssClass("actions").Icon(FA.Edit)
                .OnClick(x => x.Go<UI.Pages.Owner.EnterPage>()
                .Send("item", "item.ID")
                .SendReturnUrl());

            ButtonColumn("Delete")
                .HeaderText("Delete")
                .Icon(FA.Remove)
                .GridColumnCssClass("actions")
                .ConfirmQuestion("Are you sure you want to delete this owner?")
                .CssClass("btn-danger")
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.Reload();
                });

            Button("New Owner").Icon(FA.Plus)
                .OnClick(x => x.Go<UI.Pages.Owner.EnterPage>()
                .SendReturnUrl());
        }
    }
}
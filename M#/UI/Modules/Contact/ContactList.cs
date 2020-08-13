using MSharp;

namespace Modules
{
    class ContactList : ListModule<Domain.Contact>
    {
        public ContactList()
        {
            Column(x => x.Category);
            Column(x => x.FirstName);
            Column(x => x.LastName);
            Column(x => x.Tel);
            Column(x => x.Email);

            ButtonColumn("Edit").HeaderText("Actions").GridColumnCssClass("actions").Icon(FA.Edit)
                .OnClick(x => x.Go < ...Page > ().Send("item", "item.ID"));

            Button("New Contact").Icon(FA.Plus)
                .OnClick(x => x.Go < ...Page > ());
        }
    }
}
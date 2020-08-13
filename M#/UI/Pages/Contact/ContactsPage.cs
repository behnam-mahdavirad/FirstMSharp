using MSharp;

namespace UI.Pages.Contact
{
    public class ContactsPage : SubPage<ContactPage>
    {
        public ContactsPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.ContactsList>();
        }
    }
}

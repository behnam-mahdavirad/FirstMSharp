using MSharp;

namespace UI.Pages.Contact
{
    public class EnterPage : SubPage<ContactsPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.ContactForm>();
        }
    }
}

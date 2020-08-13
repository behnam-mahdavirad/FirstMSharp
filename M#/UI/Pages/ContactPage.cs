using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Pages
{
    public class ContactPage : RootPage
    {
        public ContactPage()
        {
            Add<Modules.MainMenu>();

            OnStart(x => x.Go<Contact.ContactsPage>().RunServerSide());
        }
    }
}

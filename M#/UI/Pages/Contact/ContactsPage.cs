using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Pages.Contact
{
    class ContactsPage : SubPage<ContactPage>
    {
        public ContactsPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.ContactsList>():
        }
    }
}

using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

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

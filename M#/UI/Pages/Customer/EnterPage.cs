using Modules;
using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Pages.Customer
{
    public class EnterPage : SubPage<CustomerPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Add<Modules.CustomerForm>();
        }
    }
}

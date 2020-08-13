using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Pages.Customer
{
    public class CustomersPage : SubPage<CustomerPage>
    {
        public CustomersPage()
        {
            Add<Modules.CustomersList>();
        }
    }
}

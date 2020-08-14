using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Pages.Supplier
{
    public class EnterPage : SubPage<SupplierPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.SupplierForm>();
        }
    }
}

using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Pages.Manufacturer
{
    public class EnterPage : SubPage<ManufacturersPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Add<Modules.ManufacturerForm>();
        }
    }
}

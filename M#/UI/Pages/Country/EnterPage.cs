using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Pages.Country
{
    public class EnterPage : SubPage<CountriesPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Add<Modules.CountryForm>();
        }
    }
}

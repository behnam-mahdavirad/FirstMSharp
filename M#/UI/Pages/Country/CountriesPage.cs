using Domain;
using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Pages.Country
{
    public class CountriesPage : SubPage<CountryPage>
    {
        public CountriesPage()
        {
            Add<Modules.CountriesList>();
        }
    }
}

using MSharp;

namespace UI.Pages
{
    public class CountryPage : RootPage
    {
        public CountryPage()
        {
            Add<Modules.AdminSettingsMenu>();

            OnStart(x => x.Go<Country.CountriesPage>().RunServerSide());
        }
    }
}

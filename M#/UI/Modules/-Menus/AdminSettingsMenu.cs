using MSharp;
using UI.Pages;
using UI.Pages.CarModel;
using UI.Pages.Country;
using UI.Pages.Customer;
using UI.Pages.Manufacturer;

namespace Modules
{
    public class AdminSettingsMenu : MenuModule
    {
        public AdminSettingsMenu()
        {
            SubItemBehaviour(MenuSubItemBehaviour.ExpandCollapse);
            WrapInForm(false);
            AjaxRedirect();
            IsViewComponent();
            RootCssClass("sidebar-menu");
            UlCssClass("nav flex-column");
            Using("Olive.Security");

            Item("General settings")
                .OnClick(x => x.Go<Admin.Settings.GeneralPage>());

            Item("Administrators")
                .OnClick(x => x.Go<Admin.Settings.AdministratorsPage>());

            Item("Content blocks")
                .OnClick(x => x.Go<Admin.Settings.ContentBlocksPage>());

            Item("Contacts").Icon(FA.Cog)
                .OnClick(x => x.Go<ContactPage>());

            Item("Countries")
                .Icon(FA.Cog)
                .OnClick(x => x.Go<CountriesPage>());

            Item("Customers")
                .Icon(FA.Cog)
                .OnClick(x => x.Go<CustomersPage>());

            Item("Manufacturers")
                .Icon(FA.Car)
                .OnClick(x => x.Go<ManufacturerPage>());

            Item("Car models")
                .Icon(FA.Car)
                .OnClick(x => x.Go<CarModelPage>());

            Item("Projects")
                .Icon(FA.Cog)
                .OnClick(x => x.Go<ProjectPage>());

            Item("Project Tasks")
                .Icon(FA.Cog)
                .OnClick(x => x.Go<ProjectTaskPage>());
        }
    }
}
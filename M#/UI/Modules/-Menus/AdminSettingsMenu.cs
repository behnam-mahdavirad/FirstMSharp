using MSharp;
using UI.Pages;
using UI.Pages.Country;
using UI.Pages.Customer;

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

            // Example 04
            Item("Asset Types")
                .Icon(FA.AccessibleIcon)
                .OnClick(x => x.Go<AssetTypePage>());

            Item("Owners")
                .Icon(FA.AccessibleIcon)
                .OnClick(x => x.Go<OwnerPage>());

            Item("Assets List")
                .Icon(FA.AccessibleIcon)
                .OnClick(x => x.Go<AssetPage>());

            // Practice 04
            Item("Product categories")
                .Icon(FA.Ad)
                .OnClick(x => x.Go<ProductCategoryPage>());

            Item("Suppliers")
                .Icon(FA.Ad)
                .OnClick(x => x.Go<SupplierPage>());

            Item("Products")
                .Icon(FA.Ad)
                .OnClick(x => x.Go<ProductPage>());

            // Example 05
            Item("Vehicles")
                .Icon(FA.Navicon)
                .OnClick(x => x.Go<VehiclePage>());

            Item("Bikes")
                .Icon(FA.Navicon)
                .OnClick(x => x.Go<BikePage>());

            Item("Cars")
                .Icon(FA.Navicon)
                .OnClick(x => x.Go<CarPage>());
        }
    }
}
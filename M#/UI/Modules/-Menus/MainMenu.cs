using MSharp;
using UI.Pages;

namespace Modules
{
    public class MainMenu : MenuModule
    {
        public MainMenu()
        {
            SubItemBehaviour(MenuSubItemBehaviour.ExpandCollapse);
            AjaxRedirect().WrapInForm(false);
            Using("Olive.Security");
            IsViewComponent().UlCssClass("nav flex-column");
            RootCssClass("sidebar-menu");

            Link("Logout")
                 .CssClass("align-bottom logout")
                 .ValidateAntiForgeryToken(false)
                 .VisibleIf(CommonCriterion.IsUserLoggedIn)
                 .OnClick(x =>
                 {
                     x.CSharp("await OAuth.Instance.LogOff();");
                     x.Go<LoginPage>();
                 });

            Item("Contacts")
                .Icon(FA.Cog)
                .OnClick(x => x.Go<ContactPage>());
        }
    }
}
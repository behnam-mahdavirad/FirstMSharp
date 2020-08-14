using MSharp;

namespace UI.Pages.ProductCategory
{
    public class EnterPage : SubPage<ProductCategoryPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.ProductCategoryForm>();
        }
    }
}

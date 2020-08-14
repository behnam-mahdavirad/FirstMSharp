using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Pages.Product
{
    public class EnterPage : SubPage<ProductPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.ProductForm>();
        }
    }
}

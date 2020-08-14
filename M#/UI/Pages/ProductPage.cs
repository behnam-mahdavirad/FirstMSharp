using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Pages
{
    public class ProductPage : RootPage
    {
        public ProductPage()
        {
            Add<Modules.ProductsList>();
        }
    }
}

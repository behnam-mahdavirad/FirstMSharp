using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Pages.Product
{
    public class ViewPage : RootPage
    {
        public ViewPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Add<Modules.ProductView>();
        }
    }
}

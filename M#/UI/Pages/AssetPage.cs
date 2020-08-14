using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Pages
{
    public class AssetPage : RootPage
    {
        public AssetPage()
        {
            Add<Modules.AssetsList>();
        }
    }
}

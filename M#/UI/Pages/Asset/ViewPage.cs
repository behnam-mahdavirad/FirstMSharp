using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Pages.Asset
{
    public class ViewPage : SubPage<AssetPage>
    {
        public ViewPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.AssetView>();
        }
    }
}

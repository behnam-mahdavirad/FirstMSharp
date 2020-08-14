using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Pages.Asset
{
    public class EnterPage : SubPage<AssetPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.AssetForm>();
        }
    }
}

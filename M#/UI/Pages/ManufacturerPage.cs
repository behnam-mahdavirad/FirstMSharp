using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Pages
{
    public class ManufacturerPage : RootPage
    {
        public ManufacturerPage()
        {
            Add<Modules.AdminSettingsMenu>();

            OnStart(x => x.Go<Manufacturer.Manufacturers>().RunServerSide());
        }
    }
}

using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Pages.CarModel
{
    public class EnterPage : SubPage<CarModelsPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.CarModelForm>();
        }
    }
}

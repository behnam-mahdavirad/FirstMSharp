﻿using MSharp;

namespace UI.Pages.ProjectTask
{
    public class EnterPage : SubPage<ProjectTaskPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.ProjectTaskAdd>();
        }
    }
}

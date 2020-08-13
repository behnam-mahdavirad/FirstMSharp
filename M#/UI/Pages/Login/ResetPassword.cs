using MSharp;

namespace Login
{
    public class ResetPasswordPage : SubPage<LoginPage>
    {
        public ResetPasswordPage()
        {
            Route("password/reset/{ticket}");

            Add<Modules.ResetUserPassword>();
        }
    }
}
using MSharp;

namespace Login
{
    public class ForgotPasswordPage : SubPage<LoginPage>
    {
        public ForgotPasswordPage()
        {
            Add<Modules.RequestUserPasswordResetTicket>();
        }
    }
}
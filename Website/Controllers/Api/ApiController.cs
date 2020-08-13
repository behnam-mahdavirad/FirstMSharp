using Olive.Security;

namespace Controllers
{
    [JwtAuthenticate]
    public class ApiController : BaseController
    {
    }
}
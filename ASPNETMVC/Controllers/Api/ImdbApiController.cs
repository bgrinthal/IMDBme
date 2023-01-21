using Microsoft.AspNetCore.Mvc;

namespace ASPNETMVC.Controllers.Api
{
    public class ImdbApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

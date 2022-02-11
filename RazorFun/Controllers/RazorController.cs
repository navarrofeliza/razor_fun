using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace RazorFun.Controllers
{
    public class RazorFunController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Foods()
        {
            // will attempt to serve 
            // Views/Hello/Index.cshtml
            // or if that file isn't there:
            // Views/Shared/Index.cshtml
            return View();
        }
    }
}

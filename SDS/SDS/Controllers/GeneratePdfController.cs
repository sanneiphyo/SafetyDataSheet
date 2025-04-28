using Microsoft.AspNetCore.Mvc;

namespace SDS.Controllers
{
    [Route("[controller]")]
    public class GeneratePdfController : Controller
    {

        [HttpGet("")]
        // GET: GeneratePdfController
        public ActionResult Index()
        {
            return View();
        }

    }
}

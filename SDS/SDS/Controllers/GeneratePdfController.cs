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

        [HttpGet("productTable")]
        public ActionResult ProductTableView()
        {
            return View("ProductTableDesign");
        }

        [HttpGet("aidMeasurement")]
        public ActionResult AidMeasurementView()
        {
            return View("AidMeasurementDesign");
        }
    }
}

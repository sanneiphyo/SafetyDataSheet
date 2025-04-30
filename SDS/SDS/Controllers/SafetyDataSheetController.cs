using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using SDS.Data;
using Microsoft.EntityFrameworkCore;
using SDS.Models; // For HTML parsing 

namespace SDS.Controllers
{
    [Route("[controller]")]
    public class SafetyDataSheetController : Controller
    {
        private readonly SdsDbContext _context;
        private readonly IAntiforgery _antiforgery;

        // Combined constructor that takes both dependencies
        public SafetyDataSheetController(SdsDbContext context, IAntiforgery antiforgery)
        {
            _context = context;
            _antiforgery = antiforgery;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            // Get the CSRF tokens for the current request
            var tokens = _antiforgery.GetAndStoreTokens(HttpContext);

            // Pass the CSRF token to the view using ViewData
            ViewData["CSRFToken"] = tokens.RequestToken;

            return View();
        }

        
        [HttpPost("save")]
        public async Task<IActionResult> Save([FromBody] List<SDSContentItem> items)
        {
            try
            {
                //foreach (var item in items)
                //{
                //    var sdsContent = new SDSContent
                //    {
                //        HeadersHDId = item.ContentID,
                //        Content = item.Content,
                //       // ProductId auto generate (example =>P00001)
                //    };
                //    _context.SdsDbContext.Add(sdsContent);
                //}

                await _context.SaveChangesAsync();
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        public class SDSContentItem
        {
            public string ContentID { get; set; }
            public string Content { get; set; }
        }

        [HttpGet("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
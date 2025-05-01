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

        [HttpGet("Create")]
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
                foreach (var item in items)
                {
                    var sdsContent = new SDSContent
                    {
                        // HeadersHDId = item.ContentID,
                        // Content = item.Content,

                        // // Auto-generate ProductId (example => P00001)
                        // ProductId = await GenerateProductIdAsync()
                        Content = item.Content,
                        ContentID = item.ContentID,    // <-- don’t forget this or you’ll get NULL
                        HeadersHId = item.HeadersHId.ToString(),
                        HeadersHDId = item.HeadersHDId.ToString(),
                        ProductId = await GenerateProductIdAsync()
                    };
                    _context.Add(sdsContent);
                }

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
            // public string ContentID { get; set; }
            // public string Content { get; set; }
            public string ContentID { get; set; }  // this becomes your SDSContent.ContentID
            public string Content { get; set; }
            public int HeadersHId { get; set; }
            public int HeadersHDId { get; set; }
        }

        [HttpGet("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        private async Task<string> GenerateProductIdAsync()
        {
            // Generate a new ProductId based on the existing ones in the database
            var lastProduct = await _context.Products.OrderByDescending(p => p.Id).FirstOrDefaultAsync();
            if (lastProduct == null)
            {
                return "P00001"; // Start with P00001 if no products exist
            }
            else
            {
                var lastId = int.Parse(lastProduct.ProductCode.Substring(1)); // Assuming ProductCode is in the format P00001
                return "P" + (lastId + 1).ToString("D5"); // Increment and format as P00002, P00003, etc.
            }
        }
    }
}
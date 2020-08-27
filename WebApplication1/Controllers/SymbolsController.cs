using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class SymbolsController : Controller
    {
        [HttpGet("symbols/{symbol}/{slug}/news")]
        public IActionResult News(
            [FromRoute] string symbol,
            [FromRoute] string slug,
            [FromQuery] int perPage,
            [FromQuery] int page)
        {
            return View();
        }

        // [HttpGet("symbols/{symbol}/{slug?}")]
        // public IActionResult Details(
        //     [FromRoute] string symbol,
        //     [FromRoute] string slug)
        // {
        //     return View();
        // }
    }
}
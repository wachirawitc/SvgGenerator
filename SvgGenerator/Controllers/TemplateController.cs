using Microsoft.AspNetCore.Mvc;

namespace SvgGenerator.Controllers
{
    public class TemplateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public OkResult SaveWall(int templateId, int row, int column)
        {
            return Ok();
        }

        [HttpPost]
        public OkResult RemoveWall(int templateId, int row, int column)
        {
            return Ok();
        }
    }
}
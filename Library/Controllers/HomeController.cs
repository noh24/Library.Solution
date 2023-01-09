using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
  public class HomeController : Controller
  {
    // Routes
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    // [HttpPost("")]

  }
}
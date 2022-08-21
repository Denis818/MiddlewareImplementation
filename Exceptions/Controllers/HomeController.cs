using Microsoft.AspNetCore.Mvc;

namespace Exceptions.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet("Index")]
        public ActionResult Index()
        {
            throw new NotImplementedException();
            ///return 
        }

        [HttpGet("Details")]
        public ActionResult Details(int id)
        {
            throw new PlatformNotSupportedException();
            //return View();
        }

        [HttpPost("Create")]
        public ActionResult Create()
        {
            throw new NotFiniteNumberException();
            //return View();
        }

    }
}

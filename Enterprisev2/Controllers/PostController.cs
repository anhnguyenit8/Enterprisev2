using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Enterprisev2.Controllers
{
    public class PostController : Controller
    {
        public async Task<IActionResult>Index()
        {
            return View();
        }
    }
}

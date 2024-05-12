using Microsoft.AspNetCore.Mvc;

namespace StoreManagement.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShopDetail()
        {
            return View();
        }
    }
}

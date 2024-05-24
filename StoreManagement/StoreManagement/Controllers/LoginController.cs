using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreManagement.Data;

namespace StoreManagement.Controllers
{
    public class LoginController:Controller
    {
        private readonly DataContext _context;
        public LoginController(DataContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
           
            return View();
        }
        public async Task<ActionResult> Login(string userName, string passWord)
        {
            if (string.IsNullOrEmpty(userName))
            {
                return View("Vui lòng nhập Username!");
            }
            if (string.IsNullOrEmpty(passWord))
            {
                return View("Vui lòng nhập mật khẩu!");

            }
            var user = await _context.Users.FirstOrDefaultAsync(x=>x.UserName==userName);
            if (user == null)
            {
                return View("User không tồn tại vui lòng kiểm tra lại!");

            }
            else if (user.PassWord != passWord)
            {
                return View("Sai mat khau!");
            }
            HttpContext.Session.SetString("UserId", user.UserId + "");
            HttpContext.Session.SetString("Role", user.Role + "");
            if (user.Role == "Customer")
            {
                return RedirectToAction("Index", "Home", new { userName = userName });

            }
            else
            {
                return RedirectToAction("Index", "Item");

            }

        }
    }
}


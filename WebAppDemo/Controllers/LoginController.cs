using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAppDemo.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string notuse)
        {
            var userName=Request.Form["userName"][0];
            var userPassword = Request.Form["userPassword"][0];
            if(!userName.Equals("123") || !userPassword.Equals("123"))
            {
                return BadRequest("用户名或密码错误!");
            }
            
            return Json(new { url="/Home/Index2"});

        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppDemo.Models;

namespace WebAppDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            MenuViewModel viewModel = new MenuViewModel();


            Menu menu = new Menu();
            menu.menuName = "一级菜单";
            menu.subMenus = new List<Menu>() { new Menu() { menuName = "menu" + 1, url = "index" } };
            viewModel.menus.Add(menu);

            menu = new Menu();
            menu.menuName = "一级菜单2";
            menu.subMenus = new List<Menu>() { new Menu() { menuName = "menu" + 2, url = "index" } };
            viewModel.menus.Add(menu);



            return View(viewModel);
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

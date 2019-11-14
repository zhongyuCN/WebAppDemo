using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo.Models
{
    public class Menu
    {
        public string menuName { get; set; }
        public List<Menu> subMenus { get; set; }
        public string url { get; set; }
    }
}

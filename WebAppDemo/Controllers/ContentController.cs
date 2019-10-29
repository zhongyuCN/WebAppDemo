using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppDemo.Models;

namespace WebAppDemo.Controllers
{
    public class ContentController : Controller
    {
        public IActionResult Index()
        {
            var contents = ReadTxt(@"D:\DataBase.txt");
            //for(int i = 0; i < 10; i++)
            //{
            //    contents.Add(new Content() { Id = i, title = $"{i}的标题", content = $"{i}的内容", status = 1, add_time = DateTime.Now.AddDays(-i) });
            //}
            return View(new ContentViewModel { Contents=contents});
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string queryString)
        {
            string id= Convert.ToString(Request.Form["Id"]);
            string title= Convert.ToString(Request.Form["title"]);
            string content = Convert.ToString(Request.Form["content"]);
            string status = Convert.ToString(Request.Form["status"]);
            string addDate = string.IsNullOrEmpty(Convert.ToString(Request.Form["add_time"])) ? DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"): Convert.ToString(Request.Form["add_time"]);

            AppendTxt($"{id} {title} {content} {status} {addDate}", @"D:\DataBase.txt");

            return Redirect("index");
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        private List<Content> ReadTxt(string path)
        {
            List<Content> list = new List<Content>();
            //throw new Exception("Test异常");

            using (TextReader reader=new StreamReader(path))
            {
                string line = string.Empty;
                Content content; 
                
                while (!string.IsNullOrEmpty( line = reader.ReadLine()))
                {
                   string[] array= line.Split(' ');
                    if (array.Length < 5)
                    {
                        continue;
                    }
                    content = new Content();
                    content.Id =Convert.ToInt32( array[0]);
                    content.title = array[1];
                    content.content = array[2];
                    content.status= Convert.ToInt32(array[3]);
                    content.add_time =DateTime.Parse( array[4]);
                    list.Add(content);
                }
               
            }
                return list;
        }

        private void AppendTxt(string text,string path)
        {
            using (TextWriter writer = new StreamWriter(path,true))
            {
                writer.WriteLine(text);
            }
        }

    }
}
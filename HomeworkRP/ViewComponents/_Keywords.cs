using CSharp.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStack.ViewComponents
{
    public class _Keywords : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            IList<Keyword> keywords = new List<Keyword>
            {
                new Keyword{Id =1,Name ="SQL" },
                new Keyword{Id =2,Name ="JS" },
                new Keyword{Id =3,Name ="C#" },
                new Keyword{Id =4,Name ="HTML" },
                new Keyword{Id =5,Name ="编程开发语言" },
                new Keyword{Id =6,Name ="工具软件" },
                new Keyword{Id =7,Name ="顾问咨询" },
                new Keyword{Id =8,Name ="操作系统" },
            };
            return View(keywords);
        }
    }
}

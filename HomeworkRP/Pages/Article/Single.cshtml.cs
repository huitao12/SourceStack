using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E=CSharp.Entities;
using CSharp.ArticleRepository;

namespace SourceStack.Pages.Article
{
    public class SingleModel : PageModel
    {

        private ArticleRepository articleRepository;
        public SingleModel()
        {
            articleRepository = new ArticleRepository();
        }
        public  E.Article Article { get; set; }
        public void OnGet()
        {
            int id = Convert.ToInt32(RouteData.Values["id"]);
            //int id = Convert.ToInt32(Request.Query["id"][0]);
            Article = articleRepository.Find(id);
            ViewData["AgreeCount"] = 3;
        }


    }
}

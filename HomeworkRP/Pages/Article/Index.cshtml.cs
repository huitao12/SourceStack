using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E = CSharp.Entities;
using CSharp.ArticleRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SourceStack.Pages.Article
{
    public class IndexModel : PageModel
    {
        private ArticleRepository articleRepository;
        public IndexModel()
        {
            articleRepository = new ArticleRepository();
        }
        public IList<E.Article> Articles { get; set; }

        public void OnGet()
        {
            int pageIndex = Convert.ToInt32(Request.Query["pageIndex"][0]);
            Articles = articleRepository.Get(pageIndex, 2);
            ViewData["CommentCount"] = 1;
            ViewData["AgreeCount"] = 3;
            ViewData["OpposeCount"] = 1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E = CSharp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharp.Repoistories;

namespace SourceStack.Pages.Article
{
    public class IndexModel : PageModel
    {
        private ArticleRepository articleRepository;
        public IndexModel()
        {
            articleRepository = new ArticleRepository();
        }
        public IList<E.Article> PagedArticles { get; set; }
        public int SumOfAllArticles { get; set; }

        public  int PageSize = 2;
        public void OnGet()
        {
            int pageIndex = Convert.ToInt32(Request.Query["pageIndex"][0]);//µ±Ç°Ò³
            if (pageIndex<1)
            {
                throw new ArgumentException($"pageIndex={pageIndex}");
            }

            PagedArticles = articleRepository.Get(pageIndex, PageSize);
            SumOfAllArticles = articleRepository.Get().Count();

            ViewData["CommentCount"] = 1;
            ViewData["AgreeCount"] = 3;
            ViewData["OpposeCount"] = 1;
        }
    }
}

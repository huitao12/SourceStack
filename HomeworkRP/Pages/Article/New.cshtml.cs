using System;
using System.Collections.Generic;
using System.Linq;
using E = CSharp.Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharp.Repoistories;

namespace SourceStack.Pages.Article
{
    public class NewModel : PageModel
    {
        private ArticleRepository articleRepository;
        public NewModel()
        {
            articleRepository = new ArticleRepository();
        }

        [BindProperty]
        public E.Article Article { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            articleRepository.Save(Article);
        }
    }
}

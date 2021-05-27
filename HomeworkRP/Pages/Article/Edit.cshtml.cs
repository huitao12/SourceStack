using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharp.Repoistories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E = CSharp.Entities;

namespace SourceStack.Pages.Article
{
    public class EditModel : PageModel
    {
        private ArticleRepository articleRepository;
        public EditModel()
        {
            articleRepository = new ArticleRepository();
        }


        [BindProperty]
        public E.Article Article { get; set; }
        public void OnGet()
        {
            //Article.Id = ;
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

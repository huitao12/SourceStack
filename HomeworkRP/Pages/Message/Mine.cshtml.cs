using System;
using System.Collections.Generic;
using System.Linq;
using E=CSharp.Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharp.Repoistories;

namespace SourceStack.Pages.Message
{
    public class MineModel : PageModel
    {
        private MessageRepository messageRepository;
        public MineModel()
        {
            messageRepository = new MessageRepository();
        }

        [BindProperty]
        public IList<E.Message> Messages { get; set; }

        public void OnGet()
        {
            Messages = messageRepository.GetMine(true);
        }
        public RedirectToPageResult OnPost()
        {
            foreach (var item in Messages)
            {
                if (item.Selected)
                {
                    messageRepository.Find(item.Id).Read();
                }
            }
            return RedirectToPage();
            //foreach (var item in Messages)
            //{
            //    if (item.Selected)
            //    {
            //        messageRepository.Delete(item);
            //    }
            //}
        }
    }
}

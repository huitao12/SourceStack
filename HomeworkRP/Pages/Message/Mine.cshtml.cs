using System;
using System.Collections.Generic;
using System.Linq;
using CSharp.Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharp.Repoistories;

namespace SourceStack.Pages.Message
{
    public class MineModel : PageModel
    {
        private MessageRepository messageRepository ;
        public MineModel()
        {
            messageRepository = new MessageRepository();
        }
        public string Name { get; set; }

        //[BindProperty]
        //public IList<Message> Messages { get; set; }
        //public void OnGet()
        //{
        //    Messages = messageRepository.GetMine();
        //}
        //public void OnPost()
        //{

        //}
    }
}

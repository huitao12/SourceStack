using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SourceStack.Pages.Log
{
    public class InModel : PageModel
    {
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        public void OnGet()
        {
            UserName = "Ð¡ÄÐº¢";
        }
        public void OnPost()
        {
            Page();
        }
    }
}

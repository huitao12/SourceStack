using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SourceStack.Pages.Profile
{
    public class IndexModel : PageModel
    {
        public User NewUser { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {

        }
    }
}

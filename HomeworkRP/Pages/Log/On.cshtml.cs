using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CSharp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SourceStack.Pages.Log
{
    public class InModel : PageModel
    {
        
        public User NewUser { get; set; }
        public  bool RememberMe { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            string username = Request.Form["NewUser.Name"];
            NewUser = new User { Name = username };
        }
    }
}

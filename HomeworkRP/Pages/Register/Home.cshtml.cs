using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CSharp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SourceStack.Pages.Register
{
    public class HomeModel : PageModel
    {
        public User NewUser { get; set; }
        public bool Rememberme { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            string username = Request.Form["NewUSer.Name"];
            NewUser = new User { Name = username };

            //ViewData["UserName"]= Request.Form["NewUSer.Name"];
        }
    }
}

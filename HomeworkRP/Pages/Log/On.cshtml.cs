using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CSharp.Entities;
using CSharp.Repoistories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SourceStack.Pages.Log
{
    [BindProperties]
    public class OnModel : PageModel
    {
        private UserRepository userRepository;
        public OnModel()
        {
            userRepository = new UserRepository();
        }
        public User NewUser { get; set; }
        public bool RememberMe { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            ViewData["UserName"] = Request.Form["NewUSer.Name"];

            string username = Request.Form["NewUser.Name"];
            NewUser = new User { Name = username };
            //Entities.User user= userRepository.GetByName(Name);

        }
    }
}

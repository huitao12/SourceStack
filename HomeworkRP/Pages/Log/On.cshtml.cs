using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CSharp.Entities;
using CSharp.Repoistories;
using Microsoft.AspNetCore.Http;
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
        //public User NewUser { get; set; }
        public bool RememberMe { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public void OnGet()
        {
            ViewData["hasLogOn"] = Request.Cookies[Keys.UserId];
        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            User user = userRepository.GetByName(Name);
            if (user == null)
            {
                ModelState.AddModelError(nameof(Name), "*�û���������");
                return;
            }
            if (user.Password != Password)
            {
                ModelState.AddModelError(nameof(Password), "*�û��������벻��ȷ");
                return;
            }
            ViewData["UserName"] = Request.Form["NewUSer.Name"];

            CookieOptions options = new CookieOptions();
            if (RememberMe)
            {
                options.Expires = DateTime.Now.AddDays(14);
            }//else 
            Response.Cookies.Append(Keys.UserId, user.Id.ToString(), options);


        }
    }
}

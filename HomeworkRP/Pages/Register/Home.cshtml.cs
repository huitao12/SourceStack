using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CSharp.Entities;
using CSharp.Repoistories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SourceStack.Pages.Register
{
    [BindProperties]
    public class HomeModel : PageModel
    {

        private UserRepository userRepository;
        public HomeModel()
        {
            userRepository = new UserRepository();
        }
        public User NewUser { get; set; }

        public string ConfirmPassword { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (ConfirmPassword != NewUser.Password)
            {
                ModelState.AddModelError("ConfirmPassword", "¡Ω¥Œ√‹¬Î ‰»Î≤ª“ª÷¬");
            }
            if (!ModelState.IsValid)
            {
                return;
            }
            //string username = Request.Form["NewUSer.Name"];
            //NewUser = new User { Name = username };
            ViewData["UserName"] = Request.Form["NewUSer.Name"];

            User invitedBy = userRepository.GetByName(NewUser.Invitedby.Name);
            NewUser.Invitedby = invitedBy;

            ////≈–∂œ—˚«Î»À£¨—˚«Î¬Î
            //if (invitedBy == null)
            //{

            //}
            //if (invitedBy.InviteCode != NewUser.Invitedby.InviteCode)
            //{

            //}

            //NewUser.Register();
            userRepository.Save(NewUser);
        }
    }
}

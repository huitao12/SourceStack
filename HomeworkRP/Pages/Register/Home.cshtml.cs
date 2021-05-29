using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CSharp.Entities;
using CSharp.Repoistories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
            ViewData["hasLogOn"] = Request.Cookies[Keys.UserId];
            
        }
        public void OnPost()
        {
            ////判断邀请人，邀请码
            // = userRepository.GetByName(NewUser.InvitedBy.Name);
            if (NewUser.InvitedBy == null)
            {
                ModelState.AddModelError(nameof(NewUser.InvitedBy), "邀请人不存在");
               
            }
            if (NewUser.InvitedBy.InviteCode != NewUser.InvitedBy.InviteCode)
            {
                ModelState.AddModelError(nameof(NewUser.InvitedBy.InviteCode), "邀请人的邀请码不存在");
             
            }
            if (ConfirmPassword != NewUser.Password)
            {
                ModelState.AddModelError(nameof(ConfirmPassword), "两次密码输入不一致");
            }
            if (!ModelState.IsValid)
            {
                return;
            }

            ViewData["UserName"] = Request.Form["NewUSer.Name"];

            Response.Cookies.Append(Keys.UserId, NewUser.Name.ToString(), new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(14)
            });

            //User invitedBy = userRepository.GetByName(NewUser.InvitedBy.Name);
            //NewUser.InvitedBy = invitedBy;



            //NewUser.Register();
            userRepository.Save(NewUser);

        }
    }
}

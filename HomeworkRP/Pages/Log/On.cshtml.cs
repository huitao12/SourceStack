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
        private ModelStateDictionary errorInPost; 

        public void OnGet()
        {
            ViewData["hasLogOn"] = Request.Cookies[Keys.UserId];
            //3. ��TempData��ȡ��Error��Ϣ
            Dictionary<string, string> errors = TempData[Keys.ErrorInfo] as Dictionary<string, string>;
            if (errors != null)
            {
                //4. ��Error��Ϣ��ӵ�ModelState
                foreach (var item in errors)
                {
                    ModelState.AddModelError(item.Key, item.Value);
                }
            }
            ModelState.Merge(errorInPost);
        }

        public RedirectToPageResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return RedirectToPage();
            }

            User user = userRepository.GetByName(Name);

            if (user == null)
            {
                ModelState.AddModelError(nameof(Name), "*�û���������");
                //1. ��ModelState����ȡError��Ϣ
                Dictionary<string, string> errors =
                    ModelState.Where(m => m.Value.Errors.Any())
                        .ToDictionary(
                            m => m.Key,
                            m => m.Value.Errors
                                .Select(s => s.ErrorMessage)
                                .FirstOrDefault(s => s != null));

                //2. ��Error��Ϣ��ŵ�TempData
                TempData[Keys.ErrorInfo] = errors;
                return RedirectToPage();
            }
            if (user.Password != Password)
            {
                ModelState.AddModelError(nameof(Password), "*�û��������벻��ȷ");
                //1. ��ModelState����ȡError��Ϣ
                Dictionary<string, string> errors =
                    ModelState.Where(m => m.Value.Errors.Any())
                        .ToDictionary(
                            m => m.Key,
                            m => m.Value.Errors
                                .Select(s => s.ErrorMessage)
                                .FirstOrDefault(s => s != null));

                //2. ��Error��Ϣ��ŵ�TempData
                TempData[Keys.ErrorInfo] = errors;
                return RedirectToPage();
            }

            ViewData["UserName"] = Request.Form["NewUSer.Name"];

            CookieOptions options = new CookieOptions();
            if (RememberMe)
            {
                options.Expires = DateTime.Now.AddDays(14);
            }//else 

            Response.Cookies.Append(Keys.UserId, user.Id.ToString(), options);

            return RedirectToPage();
        }
    }
}

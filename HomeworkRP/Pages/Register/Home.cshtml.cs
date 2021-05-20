using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SourceStack.Pages.Register
{
    public class HomeModel : PageModel
    {
        private UserRepository userRepository;
        public HomeModel()
        {
            userRepository = new UserRepository();
        }

        public void OnGet()
        {

        }
        public void OnPost()
        {

        }
    }
}

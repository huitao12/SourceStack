using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SourceStack.Pages
{
    public class UserPageModelModel : PageModel
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Level { get; set; }
        public void OnGet()
        {

        }
    }
}

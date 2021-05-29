using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SourceStack.Pages
{
    public class InFormModel : PageModel
    {
        public IActionResult OnGet()
        {
            Response.Cookies.Append("InForm", "true");
            return Redirect(Request.Headers["referer"]);
        }
    }
}

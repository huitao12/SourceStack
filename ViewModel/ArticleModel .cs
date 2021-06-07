using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CSharp.SRV.ViewModel
{    
    public class ArticleModel 
    {
        [Required(ErrorMessage = "*标题不能为空")]
        public string Title { get; set; }

        [Required(ErrorMessage = "*正文不能为空")]
        public string Body { get; set; }

        [Required(ErrorMessage = "*关键字不能为空")]
        public string Keyword { get; set; }

    }
}

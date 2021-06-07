using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CSharp.Entities
{    //文章 
    public class Article : Content
    {

        [Required(ErrorMessage = "*标题不能为空")]
        public string Title { get; set; }

        [Required(ErrorMessage = "*正文不能为空")]
        public string Body { get; set; }

        [Required(ErrorMessage = "*关键字不能为空")]
        public Keyword Keyword { get; set; }

        //public IList<Comment> Comments { get; set; }

        //public IList<Appraise> Appraises { get; set; }

        //public IList<Keyword> keywords { get; set; }


    }
}

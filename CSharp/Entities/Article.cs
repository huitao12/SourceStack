using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CSharp.Entities
{    //文章 
    public class Article : Content
    {
        public string Title { get; set; }

        public IList<Appraise> Appraises { get; set; }
        public IList<Comment> Comments { get; set; }
        public IList<Keyword> keywords { get; set; }


    }
}

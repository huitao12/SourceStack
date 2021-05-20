using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Entities
{    //文章 
    public class Article : Entity<int>
    {
        public DateTime PublishTime { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }


        public IList<Comment> Comments { get; set; }

        public IList<Appraise> Appraises { get; set; }

        public IList<Keyword> keywords { get; set; }


    }
}

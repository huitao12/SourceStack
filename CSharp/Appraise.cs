using CSharp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class Appraise : Content        //评价
    {

        //每个文章和评论都有一个评价
        public Article Article { get; set; }
        public Comment Comment { get; set; }


  
    }
}

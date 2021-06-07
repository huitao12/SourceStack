using CSharp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class Comment : Content //评论
    {

        //一个评论必须有一个它所评论的文章
        public Article Article { get; set; }
        public string Title { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class Comment//评论
    {
        //一个评论必须有一个它所评论的文章
        public Article Article { get; set; }
    }
}

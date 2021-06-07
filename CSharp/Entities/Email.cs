using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Entities
{
    public class Email : Entity
    {
        //Email和User有一对一的关系，参照课堂演示，在数据库上建立User外键引用Email的映射
        //按继承映射：Blog/Article/Suggest以及他们的父类Content
        public string Name { get; set; }
        public User mail { get; set; }

    }
}

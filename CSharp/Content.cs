using CSharp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public  class Content : Entity
    {
        public User Author { get; set; }
        public string Body { get; set; }
        public DateTime PublishTime { get; set; }


       
        //内容（Content）发布（Publish）的时候检查其作者（Author）是否为空，如果为空抛出“参数为空”异常
        public void Publish()
        {
            if (Author==null)
            {
                throw new Exception("参数为空");
            }
        }

    }
}

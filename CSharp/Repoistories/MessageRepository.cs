using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharp.Entities;

namespace CSharp.Repoistories
{
    public  class MessageRepository
    {
        //private static IList<Message> messages;
        //static MessageRepository()
        //{
        //    messages= new List<Message>
        //    {
        //        new Message
        //        {
        //            Id=1,
        //            Content="你因为登录获得系统随机分配给你的 帮帮豆 1 枚，可用于感谢赞赏等。",
        //            Createtime=DateTime.Now,
        //        },
        //         new Message
        //        {
        //            Id=2,
        //            Content="你因为登录获得系统随机分配给你的 帮帮豆 2 枚，可用于感谢赞赏等。",
        //            Createtime=DateTime.Now,
        //        },
        //    };
        //}
        public IList<Message> GetMine()
        {
            return  new List<Message>
            {
                new Message
                {
                    Id=1,
                    Content="你因为登录获得系统随机分配给你的 帮帮豆 1 枚，可用于感谢赞赏等。",
                    Createtime=DateTime.Now,
                },
                 new Message
                {
                    Id=2,
                    Content="你因为登录获得系统随机分配给你的 帮帮豆 2 枚，可用于感谢赞赏等。",
                    Createtime=DateTime.Now.AddHours(3),
                },
            };
        }
        //public Message Find(int id)
        //{
        //    return messages.Where(m=> m.Id == id).SingleOrDefault();
        //}

    }
}

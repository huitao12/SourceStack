using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Entities
{
    public class Message : Entity
    {
        public bool Selected { get; set; }
        public DateTime Createtime { get; set; }
        public string Content { get; set; }
        public bool HasRead { get; set; }
        public void Read()
        {
            HasRead = true;
        }
       
    }
}

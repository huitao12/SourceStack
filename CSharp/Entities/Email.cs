using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Entities
{
    public class Email : Entity
    {
        public string subject { get; set; }
        public User Owner { get; set; }

    }
}

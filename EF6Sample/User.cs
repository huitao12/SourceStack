﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Sample
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public bool IsMale { get; set; }
        public int Wallet { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Entities
{
    public class Keyword
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<Article> Article { get; set; }

    }
}

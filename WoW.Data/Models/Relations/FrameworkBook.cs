using System;
using System.Collections.Generic;
using System.Text;

namespace WoW.Data.Models.Relations
{
    public class FrameworkBook
    {
        public int FrameworkId { get; set; }
        public Framework Framework { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}

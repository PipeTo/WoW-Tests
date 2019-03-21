using System;
using System.Collections.Generic;
using System.Text;

namespace WoW.Data.Models.Relations
{
    public class BookStatus
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int StatusId { get; set; }
        public Status Status { get; set; }
    }
}

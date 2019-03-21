using System;
using System.Collections.Generic;
using System.Text;

namespace WoW.Data.Models.Relations
{
    public class RelatedTechnologyBook
    {
        public int RelatedTechnologyId { get; set; }
        public RelatedTechnology RelatedTechnology { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace WoW.Data.Models.Relations
{
    public class RelatedTechnologyVideo
    {
        public int RelatedTechnologyId { get; set; }
        public RelatedTechnology RelatedTechnology { get; set; }

        public int VideoId { get; set; }
        public Video Video { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace WoW.Data.Models.Relations
{
    public class RelatedTechnologyUrl
    {
        public int RelatedTechnologyId { get; set; }
        public RelatedTechnology RelatedTechnology { get; set; }

        public int UrlId { get; set; }
        public Url Url { get; set; }
    }
}

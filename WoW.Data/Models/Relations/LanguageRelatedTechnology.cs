using System;
using System.Collections.Generic;
using System.Text;

namespace WoW.Data.Models.Relations
{
    public class LanguageRelatedTechnology
    {
        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public int RelatedTechnologyId { get; set; }
        public RelatedTechnology RelatedTechnology { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace WoW.Data.Models.Relations
{
    public class LanguageUrl
    {
        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public int UrlId { get; set; }
        public Url Url { get; set; }
    }
}

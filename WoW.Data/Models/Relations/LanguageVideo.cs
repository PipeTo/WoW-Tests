using System;
using System.Collections.Generic;
using System.Text;

namespace WoW.Data.Models.Relations
{
    public class LanguageVideo
    {
        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public int VideoId { get; set; }
        public Video Video { get; set; }
    }
}

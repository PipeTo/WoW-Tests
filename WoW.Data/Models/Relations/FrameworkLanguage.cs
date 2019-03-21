using System;
using System.Collections.Generic;
using System.Text;

namespace WoW.Data.Models.Relations
{
    public class FrameworkLanguage
    {
        public int FrameworkId { get; set; }
        public Framework Framework { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace WoW.Data.Models.Relations
{
    public class WayOfWorkLanguage
    {
        public int WayOfWorkId { get; set; }
        public WayOfWork WayOfWork { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}

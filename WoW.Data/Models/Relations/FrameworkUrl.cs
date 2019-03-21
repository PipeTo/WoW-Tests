using System;
using System.Collections.Generic;
using System.Text;

namespace WoW.Data.Models.Relations
{
    public class FrameworkUrl
    {
        public int FrameworkId { get; set; }
        public Framework Framework { get; set; }

        public int UrlId { get; set; }
        public Url Url { get; set; }
    }
}

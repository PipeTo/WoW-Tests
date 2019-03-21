using System;
using System.Collections.Generic;
using System.Text;

namespace WoW.Data.Models.Relations
{
    public class FrameworkVideo
    {
        public int FrameworkId { get; set; }
        public Framework Framework { get; set; }

        public int VideoId { get; set; }
        public Video Video { get; set; }
    }
}

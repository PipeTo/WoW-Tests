using System;
using System.Collections.Generic;
using System.Text;

namespace WoW.Data.Models.Relations
{
    public class VideoUrl
    {
        public int VideoId { get; set; }
        public Video Video { get; set; }

        public int UrlId { get; set; }
        public Url Url { get; set; }
    }
}

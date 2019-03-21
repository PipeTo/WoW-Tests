using System;
using System.Collections.Generic;
using System.Text;

namespace WoW.Data.Models.Relations
{
    public class VideoStatus
    {
        public int VideoId { get; set; }
        public Video Video { get; set; }

        public int StatusId { get; set; }
        public Status Status { get; set; }
    }
}

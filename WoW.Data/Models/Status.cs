using System;
using System.Collections.Generic;
using System.Text;
using WoW.Data.Models.Relations;

namespace WoW.Data.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Progress { get; set; }

        public IEnumerable<BookStatus> Books { get; set; }
        public IEnumerable<VideoStatus> Videos { get; set; }
    }
}

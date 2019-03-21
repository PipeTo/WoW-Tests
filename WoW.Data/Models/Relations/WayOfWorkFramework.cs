using System;
using System.Collections.Generic;
using System.Text;

namespace WoW.Data.Models.Relations
{
    public class WayOfWorkFramework
    {
        public int WayOfWorkId { get; set; }
        public WayOfWork WayOfWork { get; set; }

        public int FrameworkId { get; set; }
        public Framework Framework { get; set; }
    }
}

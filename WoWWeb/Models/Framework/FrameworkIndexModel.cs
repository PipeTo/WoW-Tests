using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WoWWeb.Models.Framework
{
    public class FrameworkIndexModel
    {
        public string WayOfWorkName { get; set; }
        public int? WayId { get; set; }
        public IEnumerable<FrameworkListingModel> FrameworksIndex { get; set; }
    }
}

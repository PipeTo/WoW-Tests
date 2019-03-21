using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WoWWeb.Models.Home
{
    public class WowIndexModel
    {
        public IEnumerable<WowIndexListingModel> Wows { get; set; }
    }
}

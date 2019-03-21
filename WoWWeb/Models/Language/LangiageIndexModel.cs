using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WoWWeb.Models.Language
{
    public class LangiageIndexModel
    {
        public int FrameworkId { get; set; }
        public string FrameworkName { get; set; }
        public IEnumerable<LanguageListingModel> LanguageListingModel { get; set; }
    }
}

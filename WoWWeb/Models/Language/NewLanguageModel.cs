using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WoWWeb.Models.Language
{
    public class NewLanguageModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Documentation { get; set; }
        public string Tutorials { get; set; }
        public string Version { get; set; }
        public int FrameworkId { get; set; }
        public string FrameworkName { get; set; }
    }
}

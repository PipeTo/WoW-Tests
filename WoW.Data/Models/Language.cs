using System;
using System.Collections.Generic;
using System.Text;
using WoW.Data.Models.Relations;

namespace WoW.Data.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Documentation { get; set; }
        public string Tutorials { get; set; }
        public string Version { get; set; }
        public float Progress { get; set; }

        public DateTime ProjectStarted { get; set; }
        public DateTime WhenYouStartToLearn { get; set; }
        public DateTime WhenYouFinish { get; set; }

        public virtual IEnumerable<WayOfWorkLanguage> WayOfWorks { get; set; }
        public virtual IEnumerable<FrameworkLanguage> Frameworks { get; set; }
        public virtual IEnumerable<LanguageRelatedTechnology> RelatedTechnologies { get; set; }
        public virtual IEnumerable<LanguageUrl> Url { get; set; }
        public virtual IEnumerable<LanguagesBooks> Books { get; set; }
        public virtual IEnumerable<LanguageVideo> Videos { get; set; }
    }
}

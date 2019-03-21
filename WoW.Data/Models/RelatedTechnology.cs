using System;
using System.Collections.Generic;
using WoW.Data.Models.Relations;

namespace WoW.Data.Models
{
    public class RelatedTechnology
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Progress { get; set; }

        public DateTime ProjectIsStart { get; set; }
        public DateTime WhenYouStartToLearn { get; set; }
        public DateTime WhenYouFinish { get; set; }

        public virtual IEnumerable<RelatedTechnologyBook> Books { get; set; }
        public virtual IEnumerable<FrameworkRelatedTechnology> Frameworks { get; set; }
        public virtual IEnumerable<LanguageRelatedTechnology> Languages { get; set; }
        public virtual IEnumerable<RelatedTechnologyVideo> Videos { get; set; }
        public virtual IEnumerable<RelatedTechnologyUrl> Urls { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using WoW.Data.Models.Relations;

namespace WoW.Data.Models
{
     public class Framework
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Progress { get; set; }

        public DateTime ProjectStarted { get; set; }
        public DateTime WhenYouStartToLearn { get; set; }
        public DateTime WhenYouFinish { get; set; }



        public virtual IEnumerable<WayOfWorkFramework> WayOfWorks { get; set; }
        public virtual IEnumerable<FrameworkLanguage> Languages { get; set; }
        public virtual IEnumerable<FrameworkUrl> Url { get; set; }
        public virtual IEnumerable<FrameworkRelatedTechnology> RelatedTechnologies { get; set; }
        public virtual IEnumerable<FrameworkBook> Books { get; set; }
        public virtual IEnumerable<FrameworkVideo> Videos { get; set; }

    }
}

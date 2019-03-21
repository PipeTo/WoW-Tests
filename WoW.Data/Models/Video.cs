using System;
using System.Collections.Generic;
using System.Text;
using WoW.Data.Models.Relations;

namespace WoW.Data.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Watched { get; set; }
        public float Progress { get; set; }

        public DateTime Release { get; set; }
        public DateTime WhenYouStartToLearn { get; set; }
        public DateTime WhenYouFinish { get; set; }

        public virtual IEnumerable<FrameworkVideo> Frameworks { get; set; }
        public virtual IEnumerable<LanguageVideo> Languages { get; set; }
        public virtual IEnumerable<VideoStatus> Statuses { get; set; }
        public virtual IEnumerable<RelatedTechnologyVideo> RelatedTechnologies { get; set; }
        public virtual IEnumerable<VideoUrl> Urls { get; set; }


        public virtual WayOfWork WayOfWork { get; set; }
    }
}

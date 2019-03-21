using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WoW.Data.Models.Relations;

namespace WoW.Data.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Read { get; set; }
        public float Progress { get; set; }

        public DateTime WhenYouStartToLearn { get; set; }
        public DateTime WhenYouFinish { get; set; }
        public DateTime Release { get; set; }


        public byte[] Store { get; set; }


        public virtual IEnumerable<LanguagesBooks> Languages { get; set; }
        public virtual IEnumerable<BookStatus> Statuses { get; set; }
        public virtual IEnumerable<RelatedTechnologyBook> RelatedTechnologies { get; set; }
        public virtual IEnumerable<FrameworkBook> Frameworks { get; set; }

       
        public virtual WayOfWork WayOfWork { get; set; }
    }
}

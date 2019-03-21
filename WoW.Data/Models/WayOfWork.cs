using System.Collections.Generic;
using WoW.Data.Models.Relations;

namespace WoW.Data.Models
{
    public class WayOfWork
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Progress { get; set; }

        //Relations Many to Many
        public virtual IEnumerable<WayOfWorkLanguage> Languages { get; set; }
        public virtual IEnumerable<WayOfWorkFramework> Frameworks { get; set; }

        //Relation One to Many
        //Ovie se samo za testiranje na One-To-Many kako rabotat
        public virtual IEnumerable<Book> Books { get; set; }
        public virtual IEnumerable<Video> Videos { get; set; }
    }
}

using System.Collections.Generic;

namespace WoWWeb.Models.Home
{
    public class NewWayOfWorkModel
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Progress { get; set; }
        public string UrlPicture { get; set; }
    }
}

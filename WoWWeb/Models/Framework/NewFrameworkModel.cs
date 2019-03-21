using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WoWWeb.Models.Framework
{
    public class NewFrameworkModel
    {
        public int Id { get; set; }
        public string WayOfWorkName { get; set; }
        public int?  WayId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime WhenYouStart { get; set; }
        public float Process { get; set; }
    }
}

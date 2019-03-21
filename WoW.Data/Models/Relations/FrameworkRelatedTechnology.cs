﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WoW.Data.Models.Relations
{
    public class FrameworkRelatedTechnology
    {
        public int FrameworkId { get; set; }
        public Framework Framework { get; set; }

        public int RelatedTechnologyId { get; set; }
        public RelatedTechnology RelatedTechnology { get; set; }
    }
}

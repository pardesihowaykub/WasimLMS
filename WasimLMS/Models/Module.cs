﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WasimLMS.Models
{
    public class Module
    {
        public int ModuleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CourseId { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }

        public virtual ICollection<Document> Documents { get; set; }

    }
}
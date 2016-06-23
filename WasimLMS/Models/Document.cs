﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WasimLMS.Models
{
    public class Document
    {

        public int DocumentId { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public int OwnerId { get; set; }
        public int ActivityId { get; set; }
        public int CourseId { get; set; }
        public int ModuleId { get; set; }
        public virtual Activity Activity { get; set; }
        public virtual Course Course { get; set; }
        public virtual Module Module { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
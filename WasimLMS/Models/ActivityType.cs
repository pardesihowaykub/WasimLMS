using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WasimLMS.Models
{
    public class ActivityType
    {
        public int ActivityTypeId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Activity> Activity { get; set; }
    }
}
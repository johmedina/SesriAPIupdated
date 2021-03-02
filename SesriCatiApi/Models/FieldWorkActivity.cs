using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class FieldWorkActivity
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string UserId { get; set; }
        public string Activity { get; set; }
        public DateTime Created { get; set; }
        public int? CaseId { get; set; }
        public float? Longitude { get; set; }
        public float? Latitude { get; set; }
        public float? DistanceToFrame { get; set; }
        public string Note { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
        public string LastModifiedBy { get; set; }
        public string AttachmentLink { get; set; }

        public virtual DimActivity ActivityNavigation { get; set; }
        public virtual UserProfile User { get; set; }
    }
}

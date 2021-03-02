using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class FieldWorkActivitiesView
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string UserId { get; set; }
        public string Activity { get; set; }
        public int? CaseId { get; set; }
        public float? Longitude { get; set; }
        public float? Latitude { get; set; }
        public float? DistanceToFrame { get; set; }
        public string Note { get; set; }
        public DateTime Created { get; set; }
        public string LastModifiedBy { get; set; }
        public int? DimActivityId { get; set; }
        public string ActivityCode { get; set; }
        public string EnglishDisplayName { get; set; }
        public string ArabicDisplayName { get; set; }
        public int? DataCollectionMode { get; set; }
        public string ActivityRole { get; set; }
        public string AttachmentLink { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class Sample
    {
        public int ProjectId { get; set; }
        public int CaseId { get; set; }
        public string DeviceId { get; set; }
        public int? Iwid { get; set; }
        public string InterviewerId { get; set; }
        public string HeadId { get; set; }
        public string SupervisedById { get; set; }
        public int? GroupName { get; set; }
        public int? StreetNo { get; set; }
        public string BuildingmunNo { get; set; }
        public float? Latitude { get; set; }
        public float? Longitude { get; set; }
        public int? Hhtype { get; set; }
        public DateTime? InterviewDate { get; set; }
        public float? InterviewLatitude { get; set; }
        public float? InterviewLongitude { get; set; }
        public int? Status { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
        public string LastModifiedBy { get; set; }
        public string Note { get; set; }
        public int? CorrectedCaseId { get; set; }

        public virtual UserProfile LastModifiedByNavigation { get; set; }
        public virtual Project Project { get; set; }
    }
}

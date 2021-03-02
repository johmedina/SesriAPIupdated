using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class HouseholdVerificationVisit1
    {
        public int CaseId { get; set; }
        public int ProjectId { get; set; }
        public string SupervisedBy { get; set; }
        public int? ConfirmStatus { get; set; }
        public int? HouseholdTypeVerifStatus { get; set; }
        public int? StreetNoVerifStatus { get; set; }
        public int? BuildingMunNoVerifStatus { get; set; }
        public int? GeoLocationVerifStatus { get; set; }
        public float? VerificationVisitLatitude { get; set; }
        public float? VerificationVisitLongitude { get; set; }
        public float? DistanceToFrame { get; set; }
        public float? DistancetoInterview { get; set; }
        public float? DistancetoField { get; set; }
        public string Note { get; set; }
        public DateTime? VerificationVisitDate { get; set; }
        public int? VerificationStatus { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
        public string LastModifiedBy { get; set; }
        public int? Qc1 { get; set; }
        public int? Qc2 { get; set; }
        public int? Qc3 { get; set; }
        public int? Qc4 { get; set; }
        public int? Qc5 { get; set; }
        public int? Qc6 { get; set; }
        public int? Qc7 { get; set; }
        public int? Qc8 { get; set; }
        public int? Qc9 { get; set; }
        public int? CaseIdVerifStatus { get; set; }
    }
}

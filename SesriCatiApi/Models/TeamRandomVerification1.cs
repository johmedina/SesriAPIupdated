using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class TeamRandomVerification1
    {
        public int Id { get; set; }
        public string TempEmployee { get; set; }
        public string SupervisedBy { get; set; }
        public int CaseId { get; set; }
        public int ProjectId { get; set; }
        public DateTime VisitDate { get; set; }
        public int VisitNo { get; set; }
        public float VisitLongitude { get; set; }
        public float VisitLatitude { get; set; }
        public bool Consent { get; set; }
        public bool Badge { get; set; }
        public int Appearance { get; set; }
        public int Headdress { get; set; }
        public int Wearing { get; set; }
        public int Cleanliness { get; set; }
        public int Shoes { get; set; }
        public int? DeviceBatteryPercentage { get; set; }
        public int AttendInterview { get; set; }
        public int Score { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class Project
    {
        public Project()
        {
            AllCaseData = new HashSet<AllCaseData>();
            Appointment1 = new HashSet<Appointment1>();
            Availability1 = new HashSet<Availability1>();
            DialHistory1 = new HashSet<DialHistory1>();
            HouseholdVerificationVisit = new HashSet<HouseholdVerificationVisit>();
            ProjectEmployee = new HashSet<ProjectEmployee>();
            ProjectSettings = new HashSet<ProjectSettings>();
            Sample = new HashSet<Sample>();
            Scidshift1 = new HashSet<Scidshift1>();
            SelectedCases1 = new HashSet<SelectedCases1>();
            Shift = new HashSet<Shift>();
            TeamRandomVerification = new HashSet<TeamRandomVerification>();
            WorkRequest = new HashSet<WorkRequest>();
        }

        public int ProjectId { get; set; }
        public string ProjectCode { get; set; }
        public string EnglishDisplayName { get; set; }
        public string ArabicDisplayName { get; set; }
        public int Phase { get; set; }
        public int DataCollectionMode { get; set; }
        public bool IsActive { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }

        public virtual UserProfile LastModifiedByNavigation { get; set; }
        public virtual ICollection<AllCaseData> AllCaseData { get; set; }
        public virtual ICollection<Appointment1> Appointment1 { get; set; }
        public virtual ICollection<Availability1> Availability1 { get; set; }
        public virtual ICollection<DialHistory1> DialHistory1 { get; set; }
        public virtual ICollection<HouseholdVerificationVisit> HouseholdVerificationVisit { get; set; }
        public virtual ICollection<ProjectEmployee> ProjectEmployee { get; set; }
        public virtual ICollection<ProjectSettings> ProjectSettings { get; set; }
        public virtual ICollection<Sample> Sample { get; set; }
        public virtual ICollection<Scidshift1> Scidshift1 { get; set; }
        public virtual ICollection<SelectedCases1> SelectedCases1 { get; set; }
        public virtual ICollection<Shift> Shift { get; set; }
        public virtual ICollection<TeamRandomVerification> TeamRandomVerification { get; set; }
        public virtual ICollection<WorkRequest> WorkRequest { get; set; }
    }
}

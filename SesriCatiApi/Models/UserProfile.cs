using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class UserProfile
    {
        public UserProfile()
        {
            ActivityLogLastModifiedByNavigation = new HashSet<ActivityLog>();
            ActivityLogUser = new HashSet<ActivityLog>();
            AllCaseData = new HashSet<AllCaseData>();
            AppSettings = new HashSet<AppSettings>();
            AppTranslate = new HashSet<AppTranslate>();
            Appointment1 = new HashSet<Appointment1>();
            Availability1 = new HashSet<Availability1>();
            DailyReportCreatedByNavigation = new HashSet<DailyReport>();
            DailyReportLastModifiedByNavigation = new HashSet<DailyReport>();
            DailyReportSupervisedByNavigation = new HashSet<DailyReport>();
            DialHistory1 = new HashSet<DialHistory1>();
            DimActivity = new HashSet<DimActivity>();
            DimEvaluationCriteria = new HashSet<DimEvaluationCriteria>();
            DimIndicator = new HashSet<DimIndicator>();
            DimProjectSetting = new HashSet<DimProjectSetting>();
            EvaluationScore = new HashSet<EvaluationScore>();
            EvaluationSheetLastModifiedByNavigation = new HashSet<EvaluationSheet>();
            EvaluationSheetRatedByNavigation = new HashSet<EvaluationSheet>();
            EvaluationSheetUser = new HashSet<EvaluationSheet>();
            FieldWorkActivity = new HashSet<FieldWorkActivity>();
            HouseholdVerificationVisitLastModifiedByNavigation = new HashSet<HouseholdVerificationVisit>();
            HouseholdVerificationVisitSupervisedByNavigation = new HashSet<HouseholdVerificationVisit>();
            IssueCreatedByNavigation = new HashSet<Issue>();
            IssueLastModifiedByNavigation = new HashSet<Issue>();
            OptionSet = new HashSet<OptionSet>();
            Project = new HashSet<Project>();
            ProjectEmployeeLastModifiedByNavigation = new HashSet<ProjectEmployee>();
            ProjectEmployeeUser = new HashSet<ProjectEmployee>();
            ProjectSettingsLastModifiedByNavigation = new HashSet<ProjectSettings>();
            ProjectSettingsUser = new HashSet<ProjectSettings>();
            Sample = new HashSet<Sample>();
            ScidshiftEmployees1 = new HashSet<ScidshiftEmployees1>();
            ShiftCreatedByNavigation = new HashSet<Shift>();
            ShiftEmployees = new HashSet<ShiftEmployees>();
            ShiftLastModifiedByNavigation = new HashSet<Shift>();
            TeamRandomVerificationSupervisedByNavigation = new HashSet<TeamRandomVerification>();
            TeamRandomVerificationTempEmployeeNavigation = new HashSet<TeamRandomVerification>();
            TeamRandomVisit = new HashSet<TeamRandomVisit>();
            WorkRequestCreatedByNavigation = new HashSet<WorkRequest>();
            WorkRequestModifiedByNavigation = new HashSet<WorkRequest>();
        }

        public string UserId { get; set; }
        public string EnglishName { get; set; }
        public string ArabicName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public int Gender { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
        public string LastModifiedBy { get; set; }
        public string MainGroup { get; set; }

        public virtual ICollection<ActivityLog> ActivityLogLastModifiedByNavigation { get; set; }
        public virtual ICollection<ActivityLog> ActivityLogUser { get; set; }
        public virtual ICollection<AllCaseData> AllCaseData { get; set; }
        public virtual ICollection<AppSettings> AppSettings { get; set; }
        public virtual ICollection<AppTranslate> AppTranslate { get; set; }
        public virtual ICollection<Appointment1> Appointment1 { get; set; }
        public virtual ICollection<Availability1> Availability1 { get; set; }
        public virtual ICollection<DailyReport> DailyReportCreatedByNavigation { get; set; }
        public virtual ICollection<DailyReport> DailyReportLastModifiedByNavigation { get; set; }
        public virtual ICollection<DailyReport> DailyReportSupervisedByNavigation { get; set; }
        public virtual ICollection<DialHistory1> DialHistory1 { get; set; }
        public virtual ICollection<DimActivity> DimActivity { get; set; }
        public virtual ICollection<DimEvaluationCriteria> DimEvaluationCriteria { get; set; }
        public virtual ICollection<DimIndicator> DimIndicator { get; set; }
        public virtual ICollection<DimProjectSetting> DimProjectSetting { get; set; }
        public virtual ICollection<EvaluationScore> EvaluationScore { get; set; }
        public virtual ICollection<EvaluationSheet> EvaluationSheetLastModifiedByNavigation { get; set; }
        public virtual ICollection<EvaluationSheet> EvaluationSheetRatedByNavigation { get; set; }
        public virtual ICollection<EvaluationSheet> EvaluationSheetUser { get; set; }
        public virtual ICollection<FieldWorkActivity> FieldWorkActivity { get; set; }
        public virtual ICollection<HouseholdVerificationVisit> HouseholdVerificationVisitLastModifiedByNavigation { get; set; }
        public virtual ICollection<HouseholdVerificationVisit> HouseholdVerificationVisitSupervisedByNavigation { get; set; }
        public virtual ICollection<Issue> IssueCreatedByNavigation { get; set; }
        public virtual ICollection<Issue> IssueLastModifiedByNavigation { get; set; }
        public virtual ICollection<OptionSet> OptionSet { get; set; }
        public virtual ICollection<Project> Project { get; set; }
        public virtual ICollection<ProjectEmployee> ProjectEmployeeLastModifiedByNavigation { get; set; }
        public virtual ICollection<ProjectEmployee> ProjectEmployeeUser { get; set; }
        public virtual ICollection<ProjectSettings> ProjectSettingsLastModifiedByNavigation { get; set; }
        public virtual ICollection<ProjectSettings> ProjectSettingsUser { get; set; }
        public virtual ICollection<Sample> Sample { get; set; }
        public virtual ICollection<ScidshiftEmployees1> ScidshiftEmployees1 { get; set; }
        public virtual ICollection<Shift> ShiftCreatedByNavigation { get; set; }
        public virtual ICollection<ShiftEmployees> ShiftEmployees { get; set; }
        public virtual ICollection<Shift> ShiftLastModifiedByNavigation { get; set; }
        public virtual ICollection<TeamRandomVerification> TeamRandomVerificationSupervisedByNavigation { get; set; }
        public virtual ICollection<TeamRandomVerification> TeamRandomVerificationTempEmployeeNavigation { get; set; }
        public virtual ICollection<TeamRandomVisit> TeamRandomVisit { get; set; }
        public virtual ICollection<WorkRequest> WorkRequestCreatedByNavigation { get; set; }
        public virtual ICollection<WorkRequest> WorkRequestModifiedByNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class DailyReport
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public string SupervisedBy { get; set; }
        public int ProjectId { get; set; }
        public DateTime ReportDate { get; set; }
        public int? FinishedQatariCases { get; set; }
        public int? FinishedNonQatariCases { get; set; }
        public int? Refused { get; set; }
        public int? Others { get; set; }
        public int Total { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
        public string LastModifiedBy { get; set; }
        public int? CompletedCases { get; set; }
        public int? UnderProcessCases { get; set; }
        public int? Closed { get; set; }
        public int? NotWorking { get; set; }
        public string Note { get; set; }
        public string Groups { get; set; }

        public virtual UserProfile CreatedByNavigation { get; set; }
        public virtual UserProfile LastModifiedByNavigation { get; set; }
        public virtual UserProfile SupervisedByNavigation { get; set; }
    }
}

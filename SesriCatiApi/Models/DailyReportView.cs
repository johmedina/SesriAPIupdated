using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class DailyReportView
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public int ProjectId { get; set; }
        public string SupervisedBy { get; set; }
        public DateTime ReportDate { get; set; }
        public int? FinishedQatariCases { get; set; }
        public int? FinishedNonQatariCases { get; set; }
        public int? Refused { get; set; }
        public int? Others { get; set; }
        public int Total { get; set; }
        public int? CompletedCases { get; set; }
        public int? UnderProcessCases { get; set; }
        public int? Closed { get; set; }
        public int? NotWorking { get; set; }
        public string Note { get; set; }
        public string Groups { get; set; }
        public string EnglishName { get; set; }
        public string ArabicName { get; set; }
    }
}

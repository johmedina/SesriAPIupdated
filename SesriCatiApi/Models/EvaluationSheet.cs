using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class EvaluationSheet
    {
        public EvaluationSheet()
        {
            EvaluationScore = new HashSet<EvaluationScore>();
        }

        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string UserId { get; set; }
        public string RatedBy { get; set; }
        public int ShiftId { get; set; }
        public short? ProductivityScore { get; set; }
        public short SheetStatus { get; set; }
        public string SupervisorComments { get; set; }
        public string InterviewerComments { get; set; }
        public int? IsIwerProgressing { get; set; }
        public bool? IsSigned { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
        public DateTime Created { get; set; }
        public int? CaseId { get; set; }
        public int? TotalMinutes { get; set; }
        public int? ArrivedOnTime { get; set; }
        public int? WorkedShiftCommitment { get; set; }
        public string SupervisorFinalComment { get; set; }
        public string CatiManagerComment { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual UserProfile LastModifiedByNavigation { get; set; }
        public virtual UserProfile RatedByNavigation { get; set; }
        public virtual UserProfile User { get; set; }
        public virtual ICollection<EvaluationScore> EvaluationScore { get; set; }
    }
}

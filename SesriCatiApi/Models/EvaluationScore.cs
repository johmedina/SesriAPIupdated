using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class EvaluationScore
    {
        public int Id { get; set; }
        public int EvaluationSheetId { get; set; }
        public int CriteriaId { get; set; }
        public short Score { get; set; }
        public string Comments { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual EvaluationSheet EvaluationSheet { get; set; }
        public virtual UserProfile LastModifiedByNavigation { get; set; }
    }
}

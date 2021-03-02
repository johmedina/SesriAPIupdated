using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class AllCaseData
    {
        public int ProjectId { get; set; }
        public int CaseId { get; set; }
        public int? PhoneNumber { get; set; }
        public int? InterimOutcome { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual UserProfile LastModifiedByNavigation { get; set; }
        public virtual Project Project { get; set; }
    }
}

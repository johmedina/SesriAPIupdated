using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class QcflagData1
    {
        public int Id { get; set; }
        public string InterviewerId { get; set; }
        public int FlagId { get; set; }
        public DateTime VisitDate { get; set; }
        public string CaseId { get; set; }
        public int? Status { get; set; }
        public bool IsActive { get; set; }
        public string Note { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
        public int ProjectId { get; set; }

        public virtual DimQcflag1 DimQcflag1 { get; set; }
    }
}

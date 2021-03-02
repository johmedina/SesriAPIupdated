using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class WorkRequest1
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string CaseId { get; set; }
        public string CreatedBy { get; set; }
        public string Groups { get; set; }
        public DateTime StartTs { get; set; }
        public DateTime EndTs { get; set; }
        public string IwvNote { get; set; }
        public string HeadNote { get; set; }
        public string SupNote { get; set; }
        public string ManNote { get; set; }
        public int Status { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class DialHistory
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int CaseId { get; set; }
        public string UserId { get; set; }
        public int Status { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public int DialNum { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
    }
}

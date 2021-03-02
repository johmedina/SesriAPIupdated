using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class DailyReportDoctors1
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ProjectId { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
    }
}

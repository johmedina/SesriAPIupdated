using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class ShiftEmployees
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string UserId { get; set; }
        public int ShiftId { get; set; }
        public int? Status { get; set; }
        public bool? IsBlvalidated { get; set; }
        public double? BlworkedHours { get; set; }
        public string CreatedBy { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? FirstDial { get; set; }
        public DateTime? LastDial { get; set; }
        public int? NumDials { get; set; }
        public double? CompletionsPerHour { get; set; }
        public int? NumCompleted { get; set; }
        public bool? IsActive { get; set; }

        public virtual UserProfile LastModifiedByNavigation { get; set; }
        public virtual ProjectEmployee ProjectEmployee { get; set; }
    }
}

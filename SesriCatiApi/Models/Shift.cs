using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class Shift
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string EnglishName { get; set; }
        public string ArabicName { get; set; }
        public short? ShiftType { get; set; }
        public DateTime BegTs { get; set; }
        public DateTime EndTs { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
        public string Notes { get; set; }
        public string CustomLabel { get; set; }
        public string LastModifiedBy { get; set; }
        public bool? AllDayShift { get; set; }

        public virtual UserProfile CreatedByNavigation { get; set; }
        public virtual UserProfile LastModifiedByNavigation { get; set; }
        public virtual Project Project { get; set; }
    }
}

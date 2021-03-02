using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class Scidshift
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string ShiftName { get; set; }
        public DateTime BegTs { get; set; }
        public DateTime EndTs { get; set; }
        public string CreatedBy { get; set; }
        public string Note { get; set; }
        public string LastModify { get; set; }
        public bool? AllDayShift { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
    }
}

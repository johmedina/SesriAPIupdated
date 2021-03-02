using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class ActivityLog1
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string UserId { get; set; }
        public int? ShiftId { get; set; }
        public string Activity { get; set; }
        public DateTime BegTs { get; set; }
        public string Note { get; set; }
        public short Status { get; set; }
        public short? RequestStatus { get; set; }
        public short? RequestType { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? EndTs { get; set; }
    }
}

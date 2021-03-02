using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class Availability
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int ShiftId { get; set; }
        public string UserId { get; set; }
        public DateTime AvailableFrom { get; set; }
        public DateTime AvailableTo { get; set; }
        public string Note { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
    }
}

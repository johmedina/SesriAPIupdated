using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class ScidshiftEmployees
    {
        public int Id { get; set; }
        public int ShiftId { get; set; }
        public string UserId { get; set; }
        public int ProjectId { get; set; }
        public string CreatedBy { get; set; }
        public int ShiftEmpStatus { get; set; }
        public DateTime? SignedInTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
    }
}

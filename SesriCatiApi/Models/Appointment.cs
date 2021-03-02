using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class Appointment
    {
        public int Id { get; set; }
        public int CaseId { get; set; }
        public int ProjectId { get; set; }
        public string Hmciwv { get; set; }
        public DateTime StartTs { get; set; }
        public DateTime EndTs { get; set; }
        public int Status { get; set; }
        public string Note { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public string HmciwvEmail { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
    }
}

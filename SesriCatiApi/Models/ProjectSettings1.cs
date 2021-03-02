using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class ProjectSettings1
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int ProjectSettingId { get; set; }
        public string RoleId { get; set; }
        public string UserId { get; set; }
        public bool IsActive { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
    }
}

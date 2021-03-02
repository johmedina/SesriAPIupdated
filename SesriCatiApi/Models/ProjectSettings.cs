using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class ProjectSettings
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

        public virtual UserProfile LastModifiedByNavigation { get; set; }
        public virtual Project Project { get; set; }
        public virtual DimProjectSetting ProjectSetting { get; set; }
        public virtual UserProfile User { get; set; }
    }
}

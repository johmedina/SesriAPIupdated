using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class UserQcflagPermission
    {
        public string UserId { get; set; }
        public int ProjectId { get; set; }
        public int CategoryId { get; set; }
        public int? Permission { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual DimQcflagCategory1 DimQcflagCategory1 { get; set; }
    }
}

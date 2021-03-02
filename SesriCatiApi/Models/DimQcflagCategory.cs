using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class DimQcflagCategory
    {
        public int Id { get; set; }
        public int PkProjectId { get; set; }
        public string CategoryEnglishDisplayName { get; set; }
        public string CategoryArabicDisplayName { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
    }
}

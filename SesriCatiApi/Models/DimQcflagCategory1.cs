using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class DimQcflagCategory1
    {
        public DimQcflagCategory1()
        {
            DimQcflag1 = new HashSet<DimQcflag1>();
        }

        public int Id { get; set; }
        public int PkProjectId { get; set; }
        public string CategoryEnglishDisplayName { get; set; }
        public string CategoryArabicDisplayName { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }

        public virtual ICollection<DimQcflag1> DimQcflag1 { get; set; }
    }
}

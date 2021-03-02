using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class DimQcflag1
    {
        public DimQcflag1()
        {
            QcflagData1 = new HashSet<QcflagData1>();
        }

        public int FlagId { get; set; }
        public int ProjectId { get; set; }
        public string FlagCode { get; set; }
        public string EnglishDisplayName { get; set; }
        public string ArabicDisplayName { get; set; }
        public string EnglishDescription { get; set; }
        public string ArabicDescription { get; set; }
        public int Category { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }

        public virtual DimQcflagCategory1 DimQcflagCategory1 { get; set; }
        public virtual ICollection<QcflagData1> QcflagData1 { get; set; }
    }
}

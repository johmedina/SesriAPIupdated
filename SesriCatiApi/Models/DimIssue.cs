using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class DimIssue
    {
        public DimIssue()
        {
            Issue = new HashSet<Issue>();
        }

        public int Id { get; set; }
        public string UserLevel { get; set; }
        public string ComponentEnglish { get; set; }
        public string TypeEnglish { get; set; }
        public string TypeArabic { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
        public string ComponentArabic { get; set; }
        public short? DataCollectionMode { get; set; }

        public virtual ICollection<Issue> Issue { get; set; }
    }
}

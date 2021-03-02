using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class DimActivity
    {
        public DimActivity()
        {
            FieldWorkActivity = new HashSet<FieldWorkActivity>();
        }

        public int Id { get; set; }
        public string ActivityCode { get; set; }
        public string EnglishDisplayName { get; set; }
        public string ArabicDisplayName { get; set; }
        public int DataCollectionMode { get; set; }
        public string ActivityRole { get; set; }
        public bool HasTimer { get; set; }
        public bool? IsPaid { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }

        public virtual UserProfile LastModifiedByNavigation { get; set; }
        public virtual ICollection<FieldWorkActivity> FieldWorkActivity { get; set; }
    }
}

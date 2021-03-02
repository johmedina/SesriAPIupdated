using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class DimActivity1
    {
        public int Id { get; set; }
        public string ActivityCode { get; set; }
        public string EnglishDisplayName { get; set; }
        public string ArabicDisplayName { get; set; }
        public int DataCollectionMode { get; set; }
        public string ActivityRole { get; set; }
        public bool HasTimer { get; set; }
        public bool IsPaid { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
    }
}

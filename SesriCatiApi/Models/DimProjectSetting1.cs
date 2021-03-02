using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class DimProjectSetting1
    {
        public int Id { get; set; }
        public string EnglishDisplayName { get; set; }
        public string ArabicDisplayName { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
        public short? DataCollectionMode { get; set; }
    }
}

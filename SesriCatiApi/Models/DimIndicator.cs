using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class DimIndicator
    {
        public int Id { get; set; }
        public string IndicatorEnglish { get; set; }
        public string IndicatorArabic { get; set; }
        public string ReportingFrequency { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }

        public virtual UserProfile LastModifiedByNavigation { get; set; }
    }
}

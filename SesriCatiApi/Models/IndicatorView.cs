using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class IndicatorView
    {
        public int ProjectId { get; set; }
        public int Id { get; set; }
        public string IndicatorEnglish { get; set; }
        public string IndicatorArabic { get; set; }
        public string ReportingFrequencyEng { get; set; }
        public string ReportingFrequencyAr { get; set; }
        public double Value { get; set; }
    }
}

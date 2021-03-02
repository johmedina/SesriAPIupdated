using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class OptionSet
    {
        public int Id { get; set; }
        public string AppCode { get; set; }
        public string VariableName { get; set; }
        public int OptionValue { get; set; }
        public string EnglishLabel { get; set; }
        public string ArabicLabel { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }

        public virtual UserProfile LastModifiedByNavigation { get; set; }
    }
}

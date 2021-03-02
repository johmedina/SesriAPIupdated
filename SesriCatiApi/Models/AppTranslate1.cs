using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class AppTranslate1
    {
        public int Id { get; set; }
        public string AppCode { get; set; }
        public string Key { get; set; }
        public string EnglishValue { get; set; }
        public string ArabicValue { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class DimDialStatus1
    {
        public int Id { get; set; }
        public string EnglishDialStatus { get; set; }
        public string ArabicDialStatus { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
    }
}

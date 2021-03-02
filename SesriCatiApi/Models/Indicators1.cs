using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class Indicators1
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int IndicatorId { get; set; }
        public double Value { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class DimEvaluationCriteria1
    {
        public int Id { get; set; }
        public string ArabicDispalyName { get; set; }
        public string EnglishDisplayName { get; set; }
        public string ArabicDescription { get; set; }
        public string EnglishDescription { get; set; }
        public int DataCollectionMode { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
    }
}

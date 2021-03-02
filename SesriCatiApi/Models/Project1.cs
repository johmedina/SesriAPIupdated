using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class Project1
    {
        public int ProjectId { get; set; }
        public string ProjectCode { get; set; }
        public string EnglishDisplayName { get; set; }
        public string ArabicDisplayName { get; set; }
        public int Phase { get; set; }
        public int DataCollectionMode { get; set; }
        public bool IsActive { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class AppSettings1
    {
        public int Id { get; set; }
        public string EnglishDisplayName { get; set; }
        public string ArabicDisplayName { get; set; }
        public bool IsActive { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
        public string AppCode { get; set; }
        public string RoleId { get; set; }
    }
}

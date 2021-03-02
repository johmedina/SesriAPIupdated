using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class ProjectSettingView
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int ProjectSettingId { get; set; }
        public string UserId { get; set; }
        public bool IsActive { get; set; }
        public int? DimSettingId { get; set; }
        public string EnglishDisplayName { get; set; }
        public string ArabicDisplayName { get; set; }
        public string LastModifiedBy { get; set; }
        public string RoleId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class ProjectUsersView1
    {
        public int ProjectId { get; set; }
        public string ProjectCode { get; set; }
        public string EnglishDisplayName { get; set; }
        public string ArabicDisplayName { get; set; }
        public int Phase { get; set; }
        public string EnglishPhase { get; set; }
        public string ArabicPhase { get; set; }
        public bool IsActiveProject { get; set; }
        public string UserId { get; set; }
        public string EngUserName { get; set; }
        public string ArUserName { get; set; }
        public int? Role { get; set; }
        public string EngRole { get; set; }
        public string ArRole { get; set; }
        public string Groups { get; set; }
        public bool? IsActiveUser { get; set; }
        public string AssignedDevice { get; set; }
    }
}

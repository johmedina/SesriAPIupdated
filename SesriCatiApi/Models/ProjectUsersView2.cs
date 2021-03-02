using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class ProjectUsersView2
    {
        public int ProjectId { get; set; }
        public string ProjectCode { get; set; }
        public string EnglishDisplayName { get; set; }
        public string ArabicDisplayName { get; set; }
        public int Phase { get; set; }
        public string EnglishPhase { get; set; }
        public string ArabicPhase { get; set; }
        public bool IsActiveProject { get; set; }
        public int DataCollectionMode { get; set; }
        public string UserId { get; set; }
        public int Role { get; set; }
        public string EnglishRole { get; set; }
        public string ArabicRole { get; set; }
        public bool IsActiveUser { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class ProjectEmployee
    {
        public ProjectEmployee()
        {
            ShiftEmployees = new HashSet<ShiftEmployees>();
        }

        public int ProjectId { get; set; }
        public string UserId { get; set; }
        public int Role { get; set; }
        public string AssignedDevice { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Groups { get; set; }
        public bool IsActive { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
        public string LastModifiedBy { get; set; }
        public int Id { get; set; }

        public virtual UserProfile LastModifiedByNavigation { get; set; }
        public virtual Project Project { get; set; }
        public virtual DimRole RoleNavigation { get; set; }
        public virtual UserProfile User { get; set; }
        public virtual ICollection<ShiftEmployees> ShiftEmployees { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class DeviceHistory
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public string AssignedTo { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CheckInTime { get; set; }
        public DateTime? CheckOutTime { get; set; }
        public string Notes { get; set; }
        public DateTime? DueDate { get; set; }
        public string DeviceName { get; set; }
        public string Qutag { get; set; }
    }
}

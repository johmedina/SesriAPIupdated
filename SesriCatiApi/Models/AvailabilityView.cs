using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class AvailabilityView
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int ShiftId { get; set; }
        public DateTime AvailableFrom { get; set; }
        public DateTime AvailableTo { get; set; }
        public string DoctorUserId { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public string EngDoctorName { get; set; }
        public string ArDoctorName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Note { get; set; }
    }
}

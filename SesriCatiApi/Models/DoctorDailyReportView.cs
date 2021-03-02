using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class DoctorDailyReportView
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ProjectId { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public DateTime CreatedOn { get; set; }
        public string DrEngName { get; set; }
        public string DrArName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class AppointmentVue
    {
        public string SesriiwvEngName { get; set; }
        public string SesriiwvArName { get; set; }
        public int Id { get; set; }
        public int CaseId { get; set; }
        public int ProjectId { get; set; }
        public DateTime StartTs { get; set; }
        public string Note { get; set; }
        public string Hmciwv { get; set; }
        public DateTime EndTs { get; set; }
        public string EnglishName { get; set; }
        public string ArabicName { get; set; }
        public string HmciwvEngName { get; set; }
        public string HmciwvArName { get; set; }
        public int Status { get; set; }
        public string CreatedBy { get; set; }
        public string EnStatus { get; set; }
        public string ArStatus { get; set; }
    }
}

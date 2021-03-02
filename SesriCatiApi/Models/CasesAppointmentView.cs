using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class CasesAppointmentView
    {
        public int ProjectId { get; set; }
        public int CaseId { get; set; }
        public string Phone { get; set; }
        public string AltPhone { get; set; }
        public DateTime SurveyDate { get; set; }
        public string CaseNote { get; set; }
        public string FactSheet { get; set; }
        public string Attachment { get; set; }
        public string ResponseSheet { get; set; }
        public string Hmciwv { get; set; }
        public DateTime? StartTs { get; set; }
        public DateTime? EndTs { get; set; }
        public string AppointmentNote { get; set; }
        public int? AppointmentStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string DoctorEngName { get; set; }
        public string DoctorArName { get; set; }
        public string EngAppointmentStatus { get; set; }
        public string ArAppointmentStatus { get; set; }
        public int CaseStatus { get; set; }
        public string EngFinalCaseStatus { get; set; }
        public string ArFinalCaseStatus { get; set; }
    }
}

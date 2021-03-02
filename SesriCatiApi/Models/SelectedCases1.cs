using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class SelectedCases1
    {
        public int Id { get; set; }
        public int CaseId { get; set; }
        public int ProjectId { get; set; }
        public string Phone { get; set; }
        public string AltPhone { get; set; }
        public int Gender { get; set; }
        public DateTime SurveyDate { get; set; }
        public string Note { get; set; }
        public string FactSheet { get; set; }
        public string Attachment { get; set; }
        public string ResponseSheet { get; set; }
        public int Status { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }

        public virtual Project Project { get; set; }
    }
}

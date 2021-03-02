using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class WorkRequestView
    {
        public int Id { get; set; }
        public string CaseId { get; set; }
        public DateTime StartTs { get; set; }
        public DateTime EndTs { get; set; }
        public int ProjectId { get; set; }
        public string CreatedBy { get; set; }
        public string EnglishName { get; set; }
        public string ArabicName { get; set; }
        public string Groups { get; set; }
        public int Status { get; set; }
        public string EngStatus { get; set; }
        public string ArStatus { get; set; }
        public string IwvNote { get; set; }
        public string HeadNote { get; set; }
        public string SupNote { get; set; }
        public string RequestModifiedBy { get; set; }
        public string ManNote { get; set; }
    }
}

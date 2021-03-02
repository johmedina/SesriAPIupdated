using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class DialHistoryView
    {
        public int ProjectId { get; set; }
        public int DialId { get; set; }
        public int CaseId { get; set; }
        public string UserId { get; set; }
        public int Status { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public int DialNum { get; set; }
        public int? StatusId { get; set; }
        public string EnglishDialStatus { get; set; }
        public string ArabicDialStatus { get; set; }
        public string EngIwvName { get; set; }
        public string ArIwvName { get; set; }
    }
}

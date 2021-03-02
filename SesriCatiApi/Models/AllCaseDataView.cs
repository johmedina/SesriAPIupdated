using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class AllCaseDataView
    {
        public int ProjectId { get; set; }
        public int CaseId { get; set; }
        public int? PhoneNumber { get; set; }
        public int? InterimOutcome { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string CaseIdphoneNumber { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class ProjctIssuesView
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int IssueTypeId { get; set; }
        public string TypeEnglish { get; set; }
        public string TypeArabic { get; set; }
        public string Description { get; set; }
        public string DeviceId { get; set; }
        public int? CaseId { get; set; }
        public int Priority { get; set; }
        public int RequestStatus { get; set; }
        public string ReqStatusEng { get; set; }
        public string ReqStatusArb { get; set; }
        public string ActionTaken { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedbyNameEng { get; set; }
        public string CreatedNamebyArb { get; set; }
        public string LastModifiedBy { get; set; }
        public string ModifybyNameEng { get; set; }
        public string ModifybyNameArb { get; set; }
        public string PhoneNumber { get; set; }
        public string ComponentEnglish { get; set; }
        public string ComponentArabic { get; set; }
        public string UserLevel { get; set; }
        public DateTime? Created { get; set; }
    }
}

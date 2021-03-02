using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class IssueView
    {
        public int? UniqueId { get; set; }
        public long? Rownr { get; set; }
        public int Id { get; set; }
        public string DeviceId { get; set; }
        public int ProjectId { get; set; }
        public int? CaseId { get; set; }
        public int Priority { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Created { get; set; }
        public int RequestStatus { get; set; }
        public string EnglishStatus { get; set; }
        public string ArabicStatus { get; set; }
        public string PhoneNumber { get; set; }
        public string AttachmentLink { get; set; }
        public int IssueTypeId { get; set; }
        public string Description { get; set; }
        public string UserLevel { get; set; }
        public string ComponentEnglish { get; set; }
        public string ComponentArabic { get; set; }
        public string TypeEnglish { get; set; }
        public string TypeArabic { get; set; }
        public string ActionTaken { get; set; }
    }
}

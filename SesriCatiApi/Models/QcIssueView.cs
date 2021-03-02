using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class QcIssueView
    {
        public int Id { get; set; }
        public int IssueTypeId { get; set; }
        public string IssueTypeDesc { get; set; }
        public string Component { get; set; }
        public string Description { get; set; }
        public string DeviceId { get; set; }
        public int ProjectId { get; set; }
        public int? CaseId { get; set; }
        public int Priority { get; set; }
        public int RequestStatus { get; set; }
        public string RequestStatusDesc { get; set; }
        public string ActionTaken { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Created { get; set; }
        public string AttachmentLink { get; set; }
        public string PhoneNumber { get; set; }
    }
}

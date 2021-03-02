using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class ProjctUserFlagsView
    {
        public int Id { get; set; }
        public string InterviewerId { get; set; }
        public int FlagId { get; set; }
        public DateTime VisitDate { get; set; }
        public string CaseId { get; set; }
        public int? Status { get; set; }
        public string EnglishFlagStatus { get; set; }
        public string ArabicFlagStatus { get; set; }
        public bool IsActive { get; set; }
        public string Note { get; set; }
        public int ProjectId { get; set; }
        public string FlagCode { get; set; }
        public string EnglishDisplayName { get; set; }
        public string ArabicDisplayName { get; set; }
        public string EnglishDescription { get; set; }
        public string ArabicDescription { get; set; }
        public int Category { get; set; }
        public string EnglishCategory { get; set; }
        public string ArabicCategory { get; set; }
        public string UserId { get; set; }
        public int CategoryId { get; set; }
        public int? Permission { get; set; }
        public string EnglishName { get; set; }
        public string ArabicName { get; set; }
    }
}

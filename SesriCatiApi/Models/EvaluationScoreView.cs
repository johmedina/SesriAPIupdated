using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class EvaluationScoreView
    {
        public int? Id { get; set; }
        public int EvaluationSheetId { get; set; }
        public int ProjectId { get; set; }
        public int CriteriaId { get; set; }
        public string UserId { get; set; }
        public string RatedBy { get; set; }
        public int ShiftId { get; set; }
        public short? ProductivityScore { get; set; }
        public short SheetStatus { get; set; }
        public string ArabicDisplayName { get; set; }
        public string EnglishDisplayName { get; set; }
        public string EnglishDescription { get; set; }
        public string ArabicDescription { get; set; }
        public short? Score { get; set; }
        public string Comments { get; set; }
    }
}

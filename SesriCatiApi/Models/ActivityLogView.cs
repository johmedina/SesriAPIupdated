using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class ActivityLogView
    {
        public int? ProjectId { get; set; }
        public string UserId { get; set; }
        public string UserEnglishName { get; set; }
        public string UserArabicName { get; set; }
        public int? ShiftId { get; set; }
        public string EnglishShiftName { get; set; }
        public string ArabicShiftName { get; set; }
        public int Id { get; set; }
        public string Activity { get; set; }
        public string ActivityEnglishDisplayName { get; set; }
        public string ActivityArabicDisplayName { get; set; }
        public bool? HasTimer { get; set; }
        public DateTime BegTs { get; set; }
        public DateTime? EndTs { get; set; }
        public short Status { get; set; }
        public short? RequestStatus { get; set; }
        public short? RequestType { get; set; }
        public string EngRequestStatus { get; set; }
        public string ArRequestStatus { get; set; }
        public string EngRequestType { get; set; }
        public string ArRequestType { get; set; }
        public DateTime? ShiftStart { get; set; }
        public DateTime? ShiftEnd { get; set; }
        public string Note { get; set; }
        public short? ShiftType { get; set; }
    }
}

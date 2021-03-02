using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class ShiftEmployeesView
    {
        public int ProjectId { get; set; }
        public int Id { get; set; }
        public string EngShiftName { get; set; }
        public string ArShiftName { get; set; }
        public short? ShiftType { get; set; }
        public DateTime BegTs { get; set; }
        public DateTime EndTs { get; set; }
        public bool IsActive { get; set; }
        public string UserId { get; set; }
        public string EnglishName { get; set; }
        public string ArabicName { get; set; }
        public int? ShiftEmployeeStatus { get; set; }
        public string CreatedBy { get; set; }
        public string EmployeeAddedBy { get; set; }
        public int ShiftEmpId { get; set; }
        public string Notes { get; set; }
        public string CustomLabel { get; set; }
        public DateTime? FirstDial { get; set; }
        public DateTime? LastDial { get; set; }
        public int? NumDials { get; set; }
        public double? CompletionsPerHour { get; set; }
        public int? NumCompleted { get; set; }
        public bool? IsEmployeeActive { get; set; }
        public bool? AllDayShift { get; set; }
    }
}

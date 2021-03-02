using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class ScidshiftEmployeeVue
    {
        public int ProjectId { get; set; }
        public int Id { get; set; }
        public DateTime BegTs { get; set; }
        public DateTime EndTs { get; set; }
        public string UserId { get; set; }
        public string EnglishName { get; set; }
        public string ArabicName { get; set; }
        public string CreatedBy { get; set; }
        public string EmployeeAddedBy { get; set; }
        public int ShiftEmpId { get; set; }
        public string ShiftName { get; set; }
        public string Note { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public bool? AllDayShift { get; set; }
        public int ShiftEmpStatus { get; set; }
        public DateTime? SignedInTime { get; set; }
    }
}

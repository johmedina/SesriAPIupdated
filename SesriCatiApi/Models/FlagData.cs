using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class FlagData
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public decimal AnnualSalary { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public string LastModifiedBy { get; set; }
    }
}

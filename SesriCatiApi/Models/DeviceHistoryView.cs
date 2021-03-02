using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class DeviceHistoryView
    {
        public int? UniqueId { get; set; }
        public int Id { get; set; }
        public long? Rownr { get; set; }
        public int? DimDeviceId { get; set; }
        public string Manufacturer { get; set; }
        public string ManufacturerName { get; set; }
        public string Model { get; set; }
        public string ModelName { get; set; }
        public string SerialNumber { get; set; }
        public int? HardDiskCapacity { get; set; }
        public int? Ram { get; set; }
        public string OperatingSystem { get; set; }
        public string Cpu { get; set; }
        public int DeviceHistId { get; set; }
        public string Status { get; set; }
        public string StatusLabel { get; set; }
        public string Location { get; set; }
        public string AssignedTo { get; set; }
        public string ArAssignedTo { get; set; }
        public string EngAssignedTo { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public string CreatedBy { get; set; }
        public string ArCreatedByName { get; set; }
        public string EngCreatedByName { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CheckInTime { get; set; }
        public DateTime? CheckOutTime { get; set; }
        public string Notes { get; set; }
        public DateTime? DueDate { get; set; }
        public string DeviceName { get; set; }
        public string Qutag { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class DimDevice
    {
        public int Id { get; set; }
        public string DeviceName { get; set; }
        public string Qutag { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public int HardDiskCapacity { get; set; }
        public int Ram { get; set; }
        public string OperatingSystem { get; set; }
        public string Cpu { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}

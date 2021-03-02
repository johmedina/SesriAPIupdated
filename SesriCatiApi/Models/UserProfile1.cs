using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class UserProfile1
    {
        public string UserId { get; set; }
        public string EnglishName { get; set; }
        public string ArabicName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public int Gender { get; set; }
        public DateTime SysStartTime { get; set; }
        public DateTime SysEndTime { get; set; }
        public string LastModifiedBy { get; set; }
        public string MainGroup { get; set; }
    }
}

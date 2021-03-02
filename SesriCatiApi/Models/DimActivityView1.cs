using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class DimActivityView1
    {
        public int Id { get; set; }
        public string ActivityCode { get; set; }
        public string EnglishDisplayName { get; set; }
        public string ArabicDisplayName { get; set; }
        public bool HasTimer { get; set; }
        public string ActivityRole { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SesriCatiApi.Models
{
    public partial class IssueView
    {
        
        public int? UniqueId { get; set; }
        [Column("ROWNR")]
        public long? Rownr { get; set; }
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string DeviceId { get; set; }
        public int ProjectId { get; set; }
        public int? CaseId { get; set; }
        public int Priority { get; set; }
        [Required]
        [StringLength(20)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        public int RequestStatus { get; set; }
        [StringLength(250)]
        public string EnglishStatus { get; set; }
        [StringLength(250)]
        public string ArabicStatus { get; set; }
        [StringLength(8)]
        public string PhoneNumber { get; set; }
        public string AttachmentLink { get; set; }
        public int IssueTypeId { get; set; }
        [Required]
        public string Description { get; set; }
        [StringLength(25)]
        public string UserLevel { get; set; }
        [StringLength(50)]
        public string ComponentEnglish { get; set; }
        [StringLength(50)]
        public string ComponentArabic { get; set; }
        [StringLength(100)]
        public string TypeEnglish { get; set; }
        [StringLength(100)]
        public string TypeArabic { get; set; }
        public string ActionTaken { get; set; }
    }
}

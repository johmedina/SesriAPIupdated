using System;
using System.Collections.Generic;

namespace SesriCatiApi.Models
{
    public partial class TempSampleLoading
    {
        public int? ProjectId { get; set; }
        public int? Caseid { get; set; }
        public double? BlockNo { get; set; }
        public double? ZoneNo { get; set; }
        public double? MunicipalityNo { get; set; }
        public string رقمالحيازةالتعدادي { get; set; }
        public string OwnName { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public double? AreaSqM { get; set; }
        public string MainActivity { get; set; }
        public string TypesOfEzba { get; set; }
        public double? Interviewer { get; set; }
        public string InterviewerId { get; set; }
        public string HeadId { get; set; }
        public string SupervisedById { get; set; }
        public int? GroupN { get; set; }
        public string LastModifiedBy { get; set; }
    }
}

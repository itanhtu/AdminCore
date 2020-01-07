using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Source.Models.DBF
{
    public partial class Tbbanggiachitietuser
    {
        [Key]
        public int BanggiachitietuserId { get; set; }
        public string BanggiachitietuserTitle { get; set; }
        public string BanggiachitietuserTitle1 { get; set; }
        public string BanggiachitietuserTitle2 { get; set; }
        public string BanggiachitietuserTitle3 { get; set; }
        public string BanggiachitietuserTitle4 { get; set; }
        public string BanggiachitietuserTitle5 { get; set; }
        public string BanggiachitietuserTitle6 { get; set; }
        public string BanggiachitietuserTitle7 { get; set; }
        public string BanggiachitietuserTitle8 { get; set; }
        public string BanggiachitietuserTitle9 { get; set; }
        public string BanggiachitietuserContent { get; set; }
        public int? BanggiauserId { get; set; }
        public int? ProjectId { get; set; }
    }
}

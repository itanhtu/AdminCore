using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Source.Models.DBF
{
    public partial class Tbbanggiauser
    {
        [Key]
        public int BanggiauserId { get; set; }
        public string BanggiauserTitle { get; set; }
        public string BanggiauserTitle1 { get; set; }
        public string BanggiauserTitle2 { get; set; }
        public string BanggiauserTitle3 { get; set; }
        public string BanggiauserTitle4 { get; set; }
        public string BanggiauserTitle5 { get; set; }
        public string BanggiauserTitle6 { get; set; }
        public string BanggiauserTitle7 { get; set; }
        public string BanggiauserTitle8 { get; set; }
        public string BanggiauserTitle9 { get; set; }
        public string BanggiauserContent { get; set; }
        public int? UserId { get; set; }
        public string UserEmail { get; set; }
        public int? Goidichvu { get; set; }
    }
}

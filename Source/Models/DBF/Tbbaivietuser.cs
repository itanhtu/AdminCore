using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Source.Models.DBF
{
    public partial class Tbbaivietuser
    {
        [Key]
        public int BaivietuserId { get; set; }
        public string BaivietuserTitle { get; set; }
        public string BaivietuserContent { get; set; }
    }
}

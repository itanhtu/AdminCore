using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Source.Models.DBF
{
    public partial class Tbgiaproject
    {
        [Key]
        public int GiaprojectId { get; set; }
        public int? BaogiachitietId { get; set; }
        public int? ProjectId { get; set; }
    }
}

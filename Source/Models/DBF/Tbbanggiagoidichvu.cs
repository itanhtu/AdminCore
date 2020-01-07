using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Source.Models.DBF
{
    public partial class Tbbanggiagoidichvu
    {
        [Key]
        public int GoidichvuId { get; set; }
        public string GoidichvuName { get; set; }
        public bool? Hidden { get; set; }
    }
}

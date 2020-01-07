using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Source.Models.DBF
{
    public partial class TbformAccess
    {
        [Key]
        public int FormAccessId { get; set; }
        public string AdminEmail { get; set; }
        public int? FormId { get; set; }
        public string FormAccessType { get; set; }
        public DateTime? FormAccessDatecreate { get; set; }

        public Tbform Form { get; set; }
    }
}

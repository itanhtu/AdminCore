using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Source.Models.DBF
{
    public partial class Tbservicedetail
    {
        [Key]
        public int ServicedetailId { get; set; }
        public string ServicedetailTitle { get; set; }
        public string ServicedetailContent { get; set; }
        public DateTime? ServicedetailCreatedate { get; set; }
        public DateTime? ServicedetailDatemodified { get; set; }
        public int? Position { get; set; }
        public bool? Hidden { get; set; }
        public int? LangguageId { get; set; }
        public int? ServiceId { get; set; }

        public Tbservice Service { get; set; }
    }
}

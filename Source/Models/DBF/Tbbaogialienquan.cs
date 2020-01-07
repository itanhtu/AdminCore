using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Source.Models.DBF
{
    public partial class Tbbaogialienquan
    {
        [Key]
        public int BaogialienquanId { get; set; }
        public string BaogialienquanTitle { get; set; }
        public string BaogialienquanContent { get; set; }
        public DateTime? BaogialienquanCreatedate { get; set; }
        public DateTime? BaogialienquanDatemodified { get; set; }
        public int? Position { get; set; }
        public bool? Hidden { get; set; }
        public int? LangguageId { get; set; }
        public int? BaogiaId { get; set; }

        public Tbbaogia Baogia { get; set; }
    }
}

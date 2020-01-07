using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Source.Models.DBF
{
    public partial class Tbbaogia
    {
        public Tbbaogia()
        {
            Tbbaogialienquan = new HashSet<Tbbaogialienquan>();
        }
        [Key]
        public int BaogiaId { get; set; }
        public string BaogiaTitle1 { get; set; }
        public string BaogiaTitle2 { get; set; }
        public string BaogiaTitle3 { get; set; }
        public string BaogiaTitle4 { get; set; }
        public string BaogiaTitle5 { get; set; }
        public string BaogiaTitle6 { get; set; }
        public string BaogiaTitle7 { get; set; }
        public string BaogiaTitle8 { get; set; }
        public string BaogiaTitle9 { get; set; }
        public string BaogiaContent { get; set; }
        public int? Position { get; set; }
        public bool? Hidden { get; set; }

        public ICollection<Tbbaogialienquan> Tbbaogialienquan { get; set; }
    }
}

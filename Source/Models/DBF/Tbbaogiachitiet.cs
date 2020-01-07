using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Source.Models.DBF
{
    public partial class Tbbaogiachitiet
    {
        [Key]
        public int BaogiachitietId { get; set; }
        public string BaogiachitietTitle1 { get; set; }
        public string BaogiachitietTitle2 { get; set; }
        public string BaogiachitietTitle3 { get; set; }
        public string BaogiachitietTitle4 { get; set; }
        public string BaogiachitietTitle5 { get; set; }
        public string BaogiachitietTitle6 { get; set; }
        public string BaogiachitietTitle7 { get; set; }
        public string BaogiachitietTitle8 { get; set; }
        public string BaogiachitietTitle9 { get; set; }
        public string BaogiachitietTitle10 { get; set; }
        public string BaogiachitietTitle11 { get; set; }
        public string BaogiachitietTitle12 { get; set; }
        public string BaogiachitietTitle13 { get; set; }
        public string BaogiachitietTitle14 { get; set; }
        public string BaogiachitietTitle15 { get; set; }
        public string BaogiachitietContent { get; set; }
        public int? Position { get; set; }
        public int? BaogiaId { get; set; }
        public int? LangguageId { get; set; }
        public bool? Hidden { get; set; }
    }
}

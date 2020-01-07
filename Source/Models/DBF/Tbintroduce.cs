using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Source.Models.DBF
{
    public partial class Tbintroduce
    {
        [Key]
        public int IntroId { get; set; }
        public string IntroTitle { get; set; }
        public string IntroImage { get; set; }
        public string IntroSummary { get; set; }
        public string IntroConntent { get; set; }
        public string IntroAuthor { get; set; }
        public DateTime? IntroCreatedate { get; set; }
        public DateTime? IntroDatemodified { get; set; }
        public int? LangguageId { get; set; }
        public int? Position { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Source.Models.DBF
{
    public partial class Tblanguage
    {
        [Key]
        public int LangguageId { get; set; }
        public string LanguageName { get; set; }
        public string LanguageIcon { get; set; }
        public string LanguageCode { get; set; }
        public DateTime? Dtecreated { get; set; }
        public DateTime? Datemodified { get; set; }
        public int? Position { get; set; }
    }
}

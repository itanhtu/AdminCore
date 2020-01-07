using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Source.Models.DBF
{
    public partial class Tbnews
    {
        [Key]
        public int NewsId { get; set; }
        public string NewsName { get; set; }
        public int? Position { get; set; }
        public string NewsImagename { get; set; }
        public string NewsImage { get; set; }
        public string NewsLink { get; set; }
        public string NewsNote { get; set; }
        public string NewsTitle { get; set; }
        public int? NewscateId { get; set; }
        public string NewsContent { get; set; }
        public string NewsSummary { get; set; }
        public string NewsAuthor { get; set; }
        public DateTime? Datecreated { get; set; }
        public DateTime? Datemodified { get; set; }
        public int? LangguageId { get; set; }
        public bool? Hidden { get; set; }

        public Tbnewscate Newscate { get; set; }
    }
}

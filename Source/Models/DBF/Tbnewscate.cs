using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Source.Models.DBF
{
    public partial class Tbnewscate
    {
        public Tbnewscate()
        {
            Tbnews = new HashSet<Tbnews>();
        }
        [Key]
        public int NewscateId { get; set; }
        public string NewscateName { get; set; }
        public int? Position { get; set; }
        public string NewscateImagename { get; set; }
        public string NewscateLink { get; set; }
        public string NewscateNote { get; set; }
        public int? LangguageId { get; set; }

        public ICollection<Tbnews> Tbnews { get; set; }
    }
}

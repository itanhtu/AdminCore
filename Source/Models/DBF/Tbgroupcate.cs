using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Source.Models.DBF
{
    public partial class Tbgroupcate
    {
        public Tbgroupcate()
        {
            Tbcategory = new HashSet<Tbcategory>();
        }
        [Key]
        public int GroupcateId { get; set; }
        public string GroupcateName { get; set; }
        public string GroupcateDepcription { get; set; }
        public string GroupcateIcon { get; set; }
        public int? GroupcateParent { get; set; }
        public string GroupcateMapped { get; set; }
        public int? GroupcateLevel { get; set; }
        public int? LangguageId { get; set; }
        public int? Position { get; set; }
        public DateTime? Datecreated { get; set; }
        public DateTime? Datemodified { get; set; }

        public ICollection<Tbcategory> Tbcategory { get; set; }
    }
}

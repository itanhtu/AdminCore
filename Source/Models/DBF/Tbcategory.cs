using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Source.Models.DBF
{
    public partial class Tbcategory
    {
        public Tbcategory()
        {
            Tbproject = new HashSet<Tbproject>();
        }
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDepcription { get; set; }
        public string CategoryIcon { get; set; }
        public int? CategoryParent { get; set; }
        public string CategoryMapped { get; set; }
        public int? CategoryLevel { get; set; }
        public int? LangguageId { get; set; }
        public int? Position { get; set; }
        public DateTime? Datecreated { get; set; }
        public DateTime? Datemodified { get; set; }
        public int? GroupcateId { get; set; }

        public Tbgroupcate Groupcate { get; set; }
        public ICollection<Tbproject> Tbproject { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Source.Models.DBF
{
    public partial class Tbproject
    {
        public Tbproject()
        {
            Tbimageproject = new HashSet<Tbimageproject>();
        }
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectContent { get; set; }
        public string ProjectImage { get; set; }
        public string ProjectLink { get; set; }
        public int? ProjectPrice { get; set; }
        public int? CategoryId { get; set; }
        public int? ServiceId { get; set; }
        public int? LangguageId { get; set; }
        public bool? ProjectHidden { get; set; }
        public int? Position { get; set; }

        public Tbcategory Category { get; set; }
        public Tbservice Service { get; set; }
        public ICollection<Tbimageproject> Tbimageproject { get; set; }
    }
}

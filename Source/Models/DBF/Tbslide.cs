using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Source.Models.DBF
{
    public partial class Tbslide
    {
        [Key]
        public int SlideId { get; set; }
        public string SlideImage { get; set; }
        public string SlideTitle1 { get; set; }
        public string SlideTitle2 { get; set; }
        public string SlideTitle3 { get; set; }
        public string SlideLink { get; set; }
    }
}

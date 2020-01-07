using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Source.Models.DBF
{
    public partial class Tblogo
    {
        [Key]
        public int LogoId { get; set; }
        public string LogoImage { get; set; }
        public string LogoName { get; set; }
        public string LogoLink { get; set; }
    }
}

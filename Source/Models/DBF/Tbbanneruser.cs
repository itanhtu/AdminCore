using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Source.Models.DBF
{
    public partial class Tbbanneruser
    {
        [Key]
        public int BanneruserId { get; set; }
        public string BanneruserImage { get; set; }
        public string UserEmail { get; set; }
        public string BanneruserVitri { get; set; }
    }
}

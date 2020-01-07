using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Source.Models.DBF
{
    public partial class Tbadmin
    {
        [Key]
        public string AdminEmail { get; set; }
        public string AdminPassword { get; set; }
        public string AdminFullname { get; set; }
        public bool? AdminGender { get; set; }
        public string AdminPhone { get; set; }
        public string AdminAddress { get; set; }
        public string AdminAvatar { get; set; }
        public string AdminDepcription { get; set; }
        public int? AdminPosition { get; set; }
        public DateTime? AdminDatemodified { get; set; }
        public DateTime? AdminDatecreated { get; set; }
        public string AdminCode { get; set; }
        public bool? AdminFullcontrol { get; set; }
        public string AdminUsername { get; set; }
        public int? GroupId { get; set; }

        public Tbgroup Group { get; set; }
    }
}

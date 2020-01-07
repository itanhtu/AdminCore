using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Source.Models.DBF
{
    public partial class Tbreviewscustome
    {
        [Key]
        public int ReviewsId { get; set; }
        public string ReviewName { get; set; }
        public string ReviewIcon { get; set; }
        public DateTime? ReviewCreatedated { get; set; }
        public string ReviewContent { get; set; }
        public int? Position { get; set; }
        public int? LangguageId { get; set; }
        public bool? Hidden { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Source.Models.DBF
{
    public partial class Tbservice
    {
        public Tbservice()
        {
            Tbproject = new HashSet<Tbproject>();
            Tbservicedetail = new HashSet<Tbservicedetail>();
        }
        [Key]
        public int ServiceId { get; set; }
        public string ServiceTitle { get; set; }
        public string ServiceSummary { get; set; }
        public string ServiceImage { get; set; }
        public string ServiceLink { get; set; }
        public string ServiceContent { get; set; }
        public DateTime? ServiceCreatedate { get; set; }
        public DateTime? ServiceDatemodified { get; set; }
        public int? LangguageId { get; set; }
        public bool? ServiceHidden { get; set; }

        public ICollection<Tbproject> Tbproject { get; set; }
        public ICollection<Tbservicedetail> Tbservicedetail { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Source.Models.DBF
{
    public partial class Tbform
    {
        public Tbform()
        {
            TbformAccess = new HashSet<TbformAccess>();
        }
        [Key]
        public int FormId { get; set; }
        public string FormName { get; set; }
        public string FormLink { get; set; }
        public int? FormPosition { get; set; }
        public string FormIcon { get; set; }
        public string FormDepcription { get; set; }
        public DateTime? FormDatecreated { get; set; }
        public DateTime? FormDatemodified { get; set; }
        public string FormCode { get; set; }
        public int? ModuleId { get; set; }

        public Tbmodule Module { get; set; }
        public ICollection<TbformAccess> TbformAccess { get; set; }
    }
}

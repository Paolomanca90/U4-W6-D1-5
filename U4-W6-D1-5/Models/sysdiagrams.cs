namespace U4_W6_D1_5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysdiagrams
    {
        [Required]
        [StringLength(128)]
        public string name { get; set; }

        public int principal_id { get; set; }

        [Key]
        public int diagram_id { get; set; }

        public int? version { get; set; }

        public byte[] definition { get; set; }
    }
}

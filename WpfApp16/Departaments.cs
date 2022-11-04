namespace WpfApp16
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Departaments
    {
        [Key]
        public int id_departament { get; set; }

        [Required]
        [StringLength(50)]
        public string departament_name { get; set; }

        public int id_count { get; set; }
    }
}

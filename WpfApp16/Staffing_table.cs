namespace WpfApp16
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Staffing_table
    {
        [Key]
        public int id_staffingtable { get; set; }

        public int id_post { get; set; }

        public int id_worker { get; set; }

        public int id_depatament { get; set; }

        [Column(TypeName = "money")]
        public decimal salary { get; set; }

        public int id_category { get; set; }
    }
}

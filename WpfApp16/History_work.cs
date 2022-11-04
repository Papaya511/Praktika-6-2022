namespace WpfApp16
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class History_work
    {
        [Key]
        public int id_history { get; set; }

        public int id_worker { get; set; }

        public int id_departament { get; set; }

        public int id_post { get; set; }

        public int id_category { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_start_work { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_end_work { get; set; }
    }
}

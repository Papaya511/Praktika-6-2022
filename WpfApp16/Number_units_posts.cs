namespace WpfApp16
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Number_units_posts
    {
        [Key]
        public int id_count { get; set; }

        public int count { get; set; }

        public int id_departament { get; set; }

        public int id_post { get; set; }
    }
}

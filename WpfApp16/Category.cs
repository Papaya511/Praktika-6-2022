namespace WpfApp16
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        [Key]
        public int id_category { get; set; }

        [Column("category")]
        public int category1 { get; set; }

        public int id_post { get; set; }

        public int factor { get; set; }
    }
}

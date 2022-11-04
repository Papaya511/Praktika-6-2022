namespace WpfApp16
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Posts
    {
        [Key]
        public int id_post { get; set; }

        [Required]
        [StringLength(50)]
        public string name_post { get; set; }

        [Required]
        [StringLength(50)]
        public string short_name { get; set; }

        public int code { get; set; }

        public int id_category { get; set; }
    }
}

namespace WpfApp16
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Workers
    {
        [Key]
        public int id_worker { get; set; }

        [Required]
        [StringLength(50)]
        public string name_worker { get; set; }

        [Required]
        [StringLength(50)]
        public string surname_worker { get; set; }

        [Required]
        [StringLength(50)]
        public string patronymic { get; set; }

        public int age { get; set; }

        [Required]
        [StringLength(50)]
        public string family_status { get; set; }

        [Required]
        [StringLength(10)]
        public string gender { get; set; }

        public int id_post { get; set; }

        public int id_history { get; set; }

        public int id_category { get; set; }
    }
}

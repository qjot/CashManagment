namespace MainWpfProject.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("person")]
    public partial class person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_person { get; set; }

        [StringLength(20)]
        public string name { get; set; }

        [StringLength(30)]
        public string surname { get; set; }

        [StringLength(30)]
        public string email { get; set; }

        [StringLength(40)]
        public string password { get; set; }
    }
}

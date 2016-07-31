namespace MainWpfProject.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("account")]
    public partial class account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_account { get; set; }

        public int? sum { get; set; }
    }
}

namespace Code_First.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Merchanttable")]
    public partial class Merchanttable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string state { get; set; }

        [StringLength(50)]
        public string city { get; set; }
    }
}

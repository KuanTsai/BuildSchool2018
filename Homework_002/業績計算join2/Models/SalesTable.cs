namespace 業績計算join2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesTable")]
    public partial class SalesTable
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Salesman { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductItem { get; set; }

        public int Quantity { get; set; }
    }
}

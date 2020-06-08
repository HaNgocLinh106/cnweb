namespace WebTraSua_16.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Topping")]
    public partial class Topping
    {
        [Key]
        public int MaTopping { get; set; }

        [StringLength(1000)]
        public string LinkAnh { get; set; }

        public int? DonGia { get; set; }

        public long? MaOD { get; set; }

        public virtual SanPhamOD SanPhamOD { get; set; }
    }
}

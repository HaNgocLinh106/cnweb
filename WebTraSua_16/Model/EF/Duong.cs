namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Duong")]
    public partial class Duong
    {
        [Key]
        public int MaDuong { get; set; }

        [StringLength(20)]
        public string Loai { get; set; }

        public long? MaOD { get; set; }

        public virtual SanPhamOD SanPhamOD { get; set; }
    }
}

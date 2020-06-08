namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietGioHang")]
    public partial class ChiTietGioHang
    {
        [Key]
        public long MaChiTietGioHang { get; set; }

        public long? MaGioHang { get; set; }

        public long? MaOD { get; set; }

        public int? DonGia { get; set; }

        public int? SoLuong { get; set; }

        public virtual GioHang GioHang { get; set; }

        public virtual SanPhamOD SanPhamOD { get; set; }
    }
}

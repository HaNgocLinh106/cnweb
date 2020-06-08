namespace WebTraSua_16.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            SanPhamODs = new HashSet<SanPhamOD>();
        }

        [Key]
        public long MaSanPham { get; set; }

        [StringLength(100)]
        public string TenSanPham { get; set; }

        [StringLength(50)]
        public string MetaTitle { get; set; }

        public int? DonGia { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }

        public bool? TrangThai { get; set; }

        [StringLength(10)]
        public string LinkAnh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPhamOD> SanPhamODs { get; set; }
    }
}

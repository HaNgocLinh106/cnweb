namespace WebTraSua_16.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPhamOD")]
    public partial class SanPhamOD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPhamOD()
        {
            ChiTietGioHangs = new HashSet<ChiTietGioHang>();
            Das = new HashSet<Da>();
            Duongs = new HashSet<Duong>();
            Sizes = new HashSet<Size>();
            Toppings = new HashSet<Topping>();
        }

        [Key]
        public long MaOD { get; set; }

        [StringLength(250)]
        public string TenOD { get; set; }

        [StringLength(50)]
        public string MetaTitle { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public int? DonGia { get; set; }

        [StringLength(10)]
        public string LinkAnh { get; set; }

        public bool? TrangThai { get; set; }

        public long? MaSanPham { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietGioHang> ChiTietGioHangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Da> Das { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Duong> Duongs { get; set; }

        public virtual SanPham SanPham { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Size> Sizes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Topping> Toppings { get; set; }
    }
}

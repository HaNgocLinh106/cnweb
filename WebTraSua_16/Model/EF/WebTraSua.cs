namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WebTraSua : DbContext
    {
        public WebTraSua()
            : base("name=WebTraSua")
        {
        }

        public virtual DbSet<ChiTietGioHang> ChiTietGioHangs { get; set; }
        public virtual DbSet<Da> Das { get; set; }
        public virtual DbSet<Duong> Duongs { get; set; }
        public virtual DbSet<GioHang> GioHangs { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<PhanHoi> PhanHois { get; set; }
        public virtual DbSet<QuanTriVien> QuanTriViens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<SanPhamOD> SanPhamODs { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<Topping> Toppings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Da>()
                .Property(e => e.Loai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Duong>()
                .Property(e => e.Loai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GioHang>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.UserName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.Pass)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QuanTriVien>()
                .Property(e => e.UserName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QuanTriVien>()
                .Property(e => e.Email)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QuanTriVien>()
                .Property(e => e.Pass)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QuanTriVien>()
                .Property(e => e.PhanQuyen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.LinkAnh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SanPhamOD>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<SanPhamOD>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<SanPhamOD>()
                .Property(e => e.LinkAnh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Size>()
                .Property(e => e.Loai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Topping>()
                .Property(e => e.LinkAnh)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}

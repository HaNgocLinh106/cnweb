namespace WebTraSua_16.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuanTriVien")]
    public partial class QuanTriVien
    {
        [Key]
        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(10)]
        public string Pass { get; set; }

        [StringLength(10)]
        public string PhanQuyen { get; set; }
    }
}

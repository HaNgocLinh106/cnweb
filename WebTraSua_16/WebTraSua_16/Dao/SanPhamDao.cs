using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTraSua_16.Models;

namespace WebTraSua_16.Dao
{
    public class SanPhamDao
    {
        WebTraSua db = null;
        public SanPhamDao()
        {
            db = new WebTraSua();
        }
        public List<SanPham> Menu()
        {
            return db.SanPhams.ToList();
        }
        public SanPhamOD Detail(long MaSanPham)
        {
            return db.SanPhamODs.Find(MaSanPham);
        }
        public SanPhamOD FindEntity(long MaOD)
        {
            return db.SanPhamODs.Find(MaOD);
        }
        public SanPhamOD SanPhamOD(long MaSanPham)
        {
            var sp = db.SanPhams.Find(MaSanPham);
            return db.SanPhamODs.First(x => x.MaSanPham == sp.MaSanPham);
        }

        public List<SanPhamOD> SanPhamLQ (long MaSanPham)
        {
            var sp = db.SanPhamODs.Find(MaSanPham);
            return db.SanPhamODs.Where(x => x.MaSanPham == sp.MaSanPham && x.MaOD != sp.MaOD).ToList();
        }

        public List<SanPham> ListSP(int top)
        {
            return db.SanPhams.Take(top).ToList();
        }
    }
    
}
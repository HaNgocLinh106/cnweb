using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTraSua_16.Models
{
    [Serializable]
    public class CartItem
    {
        public SanPhamOD SanphamOD { get; set; }
        public int Quantity { set; get; }
        public string Duong { set; get; }
    }
    public class Cart
    {
        private List<CartItem> lineCollection = new List<CartItem>();

        public void AddItem(SanPhamOD sp, int quantity, string duong)
        {
            CartItem line = lineCollection
                .Where(p => p.SanphamOD.MaOD == sp.MaOD)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartItem
                {
                    SanphamOD = sp,
                    Quantity = quantity,
                    Duong = duong
                });
            }
            else
            {
                line.Quantity += quantity;
                if (line.Quantity <= 0)
                {
                    lineCollection.RemoveAll(l => l.SanphamOD.MaOD == sp.MaOD);
                }
            }
        }

        public void RemoveLine(SanPhamOD sp)
        {
            lineCollection.RemoveAll(l => l.SanphamOD.MaOD == sp.MaOD);
        }

        public int? ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.SanphamOD.DonGia * e.Quantity);

        }
        public int? ComputeTotalProduct()
        {
            return lineCollection.Sum(e => e.Quantity);

        }
        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartItem> Lines
        {
            get { return lineCollection; }
        }
    }
}
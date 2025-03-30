using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Models
{
    public class Product
    {
        public int MaHang { get; set; }      
        public string TenHang { get; set; }  
        public int MaLoai { get; set; }      
        public int SoLuongTon { get; set; }  
        public decimal GiaBan { get; set; }  

        
        public Product()
        {

        }

        
        public Product(int maHang, string tenHang, int maLoai, int soLuongTon, decimal giaBan)
        {
            MaHang = maHang;
            TenHang = tenHang;
            MaLoai = maLoai;
            SoLuongTon = soLuongTon;
            GiaBan = giaBan;
        }
    }
}

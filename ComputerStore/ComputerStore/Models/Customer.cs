using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Models
{
    public class Customer
    {
        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }

       
        public Customer()
        {
        
        }
        public Customer(int maKH, string tenKH, string diaChi, string soDienThoai)
        {
            MaKH = maKH;
            TenKH = tenKH;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
        }
    }
}

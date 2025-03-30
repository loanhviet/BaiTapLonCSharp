using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Models
{
    public class OrderDetail
    {
        public int MaHD { get; set; }
        public int MaHang { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }

       
        public OrderDetail()
        {
        
        }

        public OrderDetail(int maHD, int maHang, int soLuong, decimal donGia, decimal thanhTien)
        {
            MaHD = maHD;
            MaHang = maHang;
            SoLuong = soLuong;
            DonGia = donGia;
            ThanhTien = thanhTien;
        }
    }
}

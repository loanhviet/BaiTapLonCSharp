using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Models
{
    public class Order
    {
        public int MaHD { get; set; }
        public int MaKH { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal TongTien { get; set; }

        
        public Order()
        {

        }

        
        public Order(int maHD, int maKH, DateTime ngayLap, decimal tongTien)
        {
            MaHD = maHD;
            MaKH = maKH;
            NgayLap = ngayLap;
            TongTien = tongTien;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiQuynhNhu_buoi_6
{
   public class SinhVienBiz: SinhVien
    {
        public double keToan;
        public double marketing;
        public double banHang;
        public override double getdiemTB()
        { return (keToan+ marketing+ banHang)/3; }
    }
}

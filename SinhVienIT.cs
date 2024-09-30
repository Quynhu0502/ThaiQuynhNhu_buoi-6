using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiQuynhNhu_buoi_6
{
 public class SinhVienIT: SinhVien
    {
        public double DiemJava;
        public double Diemcss ;

        public override double getdiemTB()
        {
          return (2* Diemcss + DiemJava)/3;
        }
    }

    
}

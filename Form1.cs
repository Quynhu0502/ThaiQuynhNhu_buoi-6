namespace ThaiQuynhNhu_buoi_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_IT_Click(object sender, EventArgs e)
        {
            SinhVienIT sinh = new SinhVienIT();
            sinh.DiemJava = 10;
            sinh.Diemcss = 8;

            MessageBox.Show(" " + sinh.getdiemTB().ToString());
        }

        private void btn_biz_Click(object sender, EventArgs e)
        {
           SinhVienBiz sinhVienBiz = new SinhVienBiz();
            sinhVienBiz.keToan = 5;
            sinhVienBiz.marketing = 9;
            sinhVienBiz.banHang = 10;

            MessageBox.Show(" " + sinhVienBiz.getdiemTB().ToString());
        }
    }
}

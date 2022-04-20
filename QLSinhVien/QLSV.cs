using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class QLSV : Form
    {
        int i;
        public QLSV(int index)
        {
            InitializeComponent();
            i= index;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVienForm sinhVien = new SinhVienForm(i); 
            sinhVien.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GiangVienForm sinhVien = new GiangVienForm(i);
            sinhVien.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NganhForm sinhVien = new NganhForm(i);
            sinhVien.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NguoiDungForm sinhVien = new NguoiDungForm(i);
            sinhVien.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LopHocPhanForm sinhVien = new LopHocPhanForm(i);
            sinhVien.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ThamGiaHocForm sinhVien = new ThamGiaHocForm(i);
            sinhVien.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MonHocForm monHocForm = new MonHocForm(i);
            monHocForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TruongForm truongForm= new TruongForm(i);
            truongForm.Show();
        }
    }
}

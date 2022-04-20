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
        public QLSV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVienForm sinhVien = new SinhVienForm(); 
            sinhVien.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GiangVienForm sinhVien = new GiangVienForm();
            sinhVien.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NganhForm sinhVien = new NganhForm();
            sinhVien.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NguoiDungForm sinhVien = new NguoiDungForm();
            sinhVien.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LopHocPhanForm sinhVien = new LopHocPhanForm();
            sinhVien.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ThamGiaHocForm sinhVien = new ThamGiaHocForm();
            sinhVien.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MonHocForm monHocForm = new MonHocForm();
            monHocForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TruongForm truongForm= new TruongForm();
            truongForm.Show();
        }
    }
}

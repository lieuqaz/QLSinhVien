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
    public partial class ThamGiaHocForm : Form
    {
        ThamGiaHocBLL bllSV;
        public ThamGiaHocForm(int i)
        {
            InitializeComponent();
            bllSV = new ThamGiaHocBLL(i);
        }
        public void ShowAllSinhVien()
        {
            DataTable dt = bllSV.getAllSinhVien();
            dataGridView1.DataSource = dt;

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            ShowAllSinhVien();
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(IDLopHocPhanTxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập IDLopHocPhan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IDLopHocPhanTxt.Focus();
                return false;
            }
            return true;
            if (string.IsNullOrEmpty(NamHocTxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập Năm Học", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NamHocTxt.Focus();
                return false;
            }
            return true;
            if (string.IsNullOrEmpty(HocKyTxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập Học Kỳ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HocKyTxt.Focus();
                return false;
            }
            return true;
            if (string.IsNullOrEmpty(IDGiangVienTxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập IDGiangVien", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IDGiangVienTxt.Focus();
                return false;
            }
            return true;

        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                ThamGiaHoc sv = new ThamGiaHoc();
                sv.IDLopHocPhan = IDLopHocPhanTxt.Text;
                sv.IDSinhVien = NamHocTxt.Text;
                sv.DiemSo = double.Parse(HocKyTxt.Text);
                sv.TenLopHoc = IDGiangVienTxt.Text;
                

                if (bllSV.AddSinhVien(sv))
                {
                    ShowAllSinhVien();
                }
                else { MessageBox.Show("Đã có lỗi xảy ra!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                IDLopHocPhanTxt.Text = dataGridView1.Rows[index].Cells["IDLopHocPhan"].Value.ToString();
                NamHocTxt.Text = dataGridView1.Rows[index].Cells["IDSinhVien"].Value.ToString();
                HocKyTxt.Text = dataGridView1.Rows[index].Cells["DiemSo"].Value.ToString();
                IDGiangVienTxt.Text = dataGridView1.Rows[index].Cells["TenLopHoc"].Value.ToString();
             

            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                ThamGiaHoc sv = new ThamGiaHoc();
                sv.IDLopHocPhan = IDLopHocPhanTxt.Text;
                sv.IDSinhVien = NamHocTxt.Text;
                sv.DiemSo = double.Parse(HocKyTxt.Text);
                sv.TenLopHoc = IDGiangVienTxt.Text;

                if (bllSV.UpdateSinhVien(sv))
                {
                    ShowAllSinhVien();
                }
                else { MessageBox.Show("Đã có lỗi xảy ra!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ThamGiaHoc sv = new ThamGiaHoc();
                sv.TenLopHoc = IDGiangVienTxt.Text;
                if (bllSV.DeleteSinhVien(sv))
                {
                    ShowAllSinhVien();
                }
                else { MessageBox.Show("Đã có lỗi xảy ra!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            }
        }




    }
}

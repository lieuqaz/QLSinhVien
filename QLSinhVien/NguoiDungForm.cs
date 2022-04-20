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
    public partial class NguoiDungForm : Form
    {
        NguoiDungBLL bllSV;
        public NguoiDungForm(int i)
        {
            InitializeComponent();
            bllSV = new NguoiDungBLL(i);
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
                MessageBox.Show("Bạn chưa nhập Tên Người Dùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IDLopHocPhanTxt.Focus();
                return false;
            }
            return true;
            if (string.IsNullOrEmpty(NamHocTxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập Password", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NamHocTxt.Focus();
                return false;
            }
            return true;
           
            return true;
            if (string.IsNullOrEmpty(IDGiangVienTxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập Thể Loại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IDGiangVienTxt.Focus();
                return false;
            }
            return true;
            if (string.IsNullOrEmpty(IDMonHocTxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập ID Sinh Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IDMonHocTxt.Focus();
                return false;
            }
            return true;
            if (string.IsNullOrEmpty(GioiHanSVTxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập Giới Hạn SV", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GioiHanSVTxt.Focus();
                return false;
            }
            return true;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                NguoiDung sv = new NguoiDung();
                sv.TenNguoiDung = IDLopHocPhanTxt.Text;
                sv.MatKhau = NamHocTxt.Text;
                sv.TheLoai = IDGiangVienTxt.Text;
                sv.IDSinhVien = IDMonHocTxt.Text;
                sv.IDTruong = GioiHanSVTxt.Text;
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
                IDLopHocPhanTxt.Text = dataGridView1.Rows[index].Cells["TenNguoiDung"].Value.ToString();
                NamHocTxt.Text = dataGridView1.Rows[index].Cells["MatKhau"].Value.ToString();     
                IDGiangVienTxt.Text = dataGridView1.Rows[index].Cells["TheLoai"].Value.ToString();
                IDMonHocTxt.Text = dataGridView1.Rows[index].Cells["IDSinhVien"].Value.ToString();
                GioiHanSVTxt.Text = dataGridView1.Rows[index].Cells["IDTruong"].Value.ToString();

            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                NguoiDung sv = new NguoiDung();
                sv.TenNguoiDung = IDLopHocPhanTxt.Text;
                sv.MatKhau = NamHocTxt.Text;
                sv.TheLoai = IDGiangVienTxt.Text;
                sv.IDSinhVien = IDMonHocTxt.Text;
                sv.IDTruong = GioiHanSVTxt.Text;

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
                NguoiDung sv = new NguoiDung();
                sv.IDSinhVien = IDMonHocTxt.Text;
                if (bllSV.DeleteSinhVien(sv))
                {
                    ShowAllSinhVien();
                }
                else { MessageBox.Show("Đã có lỗi xảy ra!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            }
        }




    }
}

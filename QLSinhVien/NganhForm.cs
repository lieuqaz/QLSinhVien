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
    public partial class NganhForm : Form
    {
        NganhBLL bllSV;
        public NganhForm(int i)
        {
            InitializeComponent();
            bllSV = new NganhBLL(i);
        }
        public void ShowAllSinhVien()
        {
            DataTable dt = bllSV.getAllSinhVien();
            dataGridView1.DataSource = dt;

        }
        private void Form5_Load(object sender, EventArgs e)
        {
            ShowAllSinhVien();
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(IDGiangVienTxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập ID Ngành", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IDGiangVienTxt.Focus();
                return false;
            }
            return true;
            if (string.IsNullOrEmpty(TenTxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập Tên Ngành", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IDGiangVienTxt.Focus();
                return false;
            }
            return true;
            if (string.IsNullOrEmpty(IDTruongTxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập IDTruong", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IDTruongTxt.Focus();
                return false;
            }
            return true;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                Nganh sv = new Nganh();
                sv.IDNganh = IDGiangVienTxt.Text;
                sv.TenNganh = TenTxt.Text;
                sv.IDTruong = IDTruongTxt.Text;
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
                IDGiangVienTxt.Text = dataGridView1.Rows[index].Cells["IDNganh"].Value.ToString();
                TenTxt.Text = dataGridView1.Rows[index].Cells["TenNganh"].Value.ToString();

                IDTruongTxt.Text = dataGridView1.Rows[index].Cells["IDTruong"].Value.ToString();


            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                Nganh sv = new Nganh();
                sv.IDNganh = IDGiangVienTxt.Text;
                sv.TenNganh = TenTxt.Text;

                sv.IDTruong = IDTruongTxt.Text;
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
                Nganh sv = new Nganh();
                sv.IDNganh = IDGiangVienTxt.Text;
                if (bllSV.DeleteSinhVien(sv))
                {
                    ShowAllSinhVien();
                }
                else { MessageBox.Show("Đã có lỗi xảy ra!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            }
        }
    }
}

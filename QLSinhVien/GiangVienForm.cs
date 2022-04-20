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
    public partial class GiangVienForm : Form
    {
        GiangVienBLL bllSV;
        public GiangVienForm()
        {
            InitializeComponent();
            bllSV = new GiangVienBLL();
        }
        public void ShowAllSinhVien()
        {
            DataTable dt = bllSV.getAllSinhVien();
            dataGridView1.DataSource = dt;

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            ShowAllSinhVien();
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(IDGiangVienTxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập IDGiangVien", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                GiangVien sv = new GiangVien();
                sv.IDGiangVien = IDGiangVienTxt.Text;
                sv.TenGiangVien = TenTxt.Text;
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
                IDGiangVienTxt.Text = dataGridView1.Rows[index].Cells["IDGiangVien"].Value.ToString();
                TenTxt.Text = dataGridView1.Rows[index].Cells["TenGiangVien"].Value.ToString();
                
                IDTruongTxt.Text = dataGridView1.Rows[index].Cells["IDTruong"].Value.ToString();
               

            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                GiangVien sv = new GiangVien();
                sv.IDGiangVien = IDGiangVienTxt.Text;
                sv.TenGiangVien = TenTxt.Text;
               
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
                GiangVien sv = new GiangVien();
                sv.IDGiangVien = IDGiangVienTxt.Text;
                if (bllSV.DeleteSinhVien(sv))
                {
                    ShowAllSinhVien();
                }
                else { MessageBox.Show("Đã có lỗi xảy ra!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            }
        }
    }
}

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
    public partial class SinhVienForm : Form
    {
        SinhVienBLL bllSV;
        public SinhVienForm()
        {
            InitializeComponent();
            bllSV=new SinhVienBLL();
        }
        public void ShowAllSinhVien()
        {
            DataTable dt = bllSV.getAllSinhVien();
            dataGridView1.DataSource= dt;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAllSinhVien();
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(IDSinhVienTxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập IDSinhVien","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                IDSinhVienTxt.Focus();
                return false;
            } return true;
            if (string.IsNullOrEmpty(TenTxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập Tên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IDSinhVienTxt.Focus();
                return false;
            }
            return true;
            if (string.IsNullOrEmpty(IDTruongTxt.Text))
            {
                MessageBox.Show("Bạn chưa nhập IDTruong", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IDSinhVienTxt.Focus();
                return false;
            }
            return true;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                SinhVien sv = new SinhVien();
                sv.IDSinhVien = IDSinhVienTxt.Text;
                sv.Ten = TenTxt.Text;
                sv.Email = EmailTxt.Text;
                sv.Tuoi = int.Parse(TuoiTxt.Text);
                sv.GioiTinh = GioiTinhTxt.Text;
                sv.DiaChi = DiaChiTxt.Text;
                sv.SDT = SDTTxt.Text;
                sv.IDTruong=IDTruongTxt.Text;
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
            if(index >= 0)
            {
                IDSinhVienTxt.Text=dataGridView1.Rows[index].Cells["IDSinhVien"].Value.ToString();
                TenTxt.Text = dataGridView1.Rows[index].Cells["Ten"].Value.ToString();
                EmailTxt.Text = dataGridView1.Rows[index].Cells["Email"].Value.ToString();
                DiaChiTxt.Text = dataGridView1.Rows[index].Cells["DiaChi"].Value.ToString();
                TuoiTxt.Text = dataGridView1.Rows[index].Cells["Tuoi"].Value.ToString();
                SDTTxt.Text = dataGridView1.Rows[index].Cells["SDT"].Value.ToString();
                IDTruongTxt.Text = dataGridView1.Rows[index].Cells["IDTruong"].Value.ToString();
                GioiTinhTxt.Text = dataGridView1.Rows[index].Cells["GioiTinh"].Value.ToString();

            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                SinhVien sv = new SinhVien();
                sv.IDSinhVien = IDSinhVienTxt.Text;
                sv.Ten = TenTxt.Text;
                sv.Email = EmailTxt.Text;
                sv.Tuoi = int.Parse(TuoiTxt.Text);
                sv.GioiTinh = GioiTinhTxt.Text;
                sv.DiaChi = DiaChiTxt.Text;
                sv.SDT = SDTTxt.Text;
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
                SinhVien sv=new SinhVien();
                sv.IDSinhVien = IDSinhVienTxt.Text;
                if (bllSV.DeleteSinhVien(sv))
                {
                    ShowAllSinhVien();
                }
                else { MessageBox.Show("Đã có lỗi xảy ra!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            }
        }


      
        
    }
}

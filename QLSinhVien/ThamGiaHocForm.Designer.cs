namespace QLSinhVien
{
    partial class ThamGiaHocForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb8 = new System.Windows.Forms.Label();
            this.IDLopHocPhanTxt = new System.Windows.Forms.TextBox();
            this.NamHocTxt = new System.Windows.Forms.TextBox();
            this.HocKyTxt = new System.Windows.Forms.TextBox();
            this.IDGiangVienTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(12, 9);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(59, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "IDMonHoc";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(12, 46);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(50, 13);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "Tên Môn";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(12, 81);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(58, 13);
            this.lb3.TabIndex = 2;
            this.lb3.Text = "Số Tín Chỉ";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(12, 122);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(49, 13);
            this.lb4.TabIndex = 3;
            this.lb4.Text = "Thể Loại";
            // 
            // lb8
            // 
            this.lb8.AutoSize = true;
            this.lb8.Location = new System.Drawing.Point(12, 291);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(0, 13);
            this.lb8.TabIndex = 7;
            // 
            // IDLopHocPhanTxt
            // 
            this.IDLopHocPhanTxt.Location = new System.Drawing.Point(93, 2);
            this.IDLopHocPhanTxt.Name = "IDLopHocPhanTxt";
            this.IDLopHocPhanTxt.Size = new System.Drawing.Size(191, 20);
            this.IDLopHocPhanTxt.TabIndex = 8;
            // 
            // NamHocTxt
            // 
            this.NamHocTxt.Location = new System.Drawing.Point(93, 39);
            this.NamHocTxt.Name = "NamHocTxt";
            this.NamHocTxt.Size = new System.Drawing.Size(191, 20);
            this.NamHocTxt.TabIndex = 9;
            // 
            // HocKyTxt
            // 
            this.HocKyTxt.Location = new System.Drawing.Point(93, 74);
            this.HocKyTxt.Name = "HocKyTxt";
            this.HocKyTxt.Size = new System.Drawing.Size(191, 20);
            this.HocKyTxt.TabIndex = 10;
            // 
            // IDGiangVienTxt
            // 
            this.IDGiangVienTxt.Location = new System.Drawing.Point(93, 114);
            this.IDGiangVienTxt.Name = "IDGiangVienTxt";
            this.IDGiangVienTxt.Size = new System.Drawing.Size(191, 20);
            this.IDGiangVienTxt.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(307, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(481, 298);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(143, 320);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 17;
            this.Add.Text = "Thêm";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(358, 320);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 18;
            this.Edit.Text = "Sửa";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(562, 320);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 19;
            this.Delete.Text = "Xóa";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ThamGiaHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.IDGiangVienTxt);
            this.Controls.Add(this.HocKyTxt);
            this.Controls.Add(this.NamHocTxt);
            this.Controls.Add(this.IDLopHocPhanTxt);
            this.Controls.Add(this.lb8);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "ThamGiaHocForm";
            this.Text = "Quản lý môn học";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.TextBox IDLopHocPhanTxt;
        private System.Windows.Forms.TextBox NamHocTxt;
        private System.Windows.Forms.TextBox HocKyTxt;
        private System.Windows.Forms.TextBox IDGiangVienTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
    }
}


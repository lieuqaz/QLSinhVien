namespace QLSinhVien
{
    partial class TruongForm
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
            this.IDGiangVienTxt = new System.Windows.Forms.TextBox();
            this.TenTxt = new System.Windows.Forms.TextBox();
            this.IDTruongTxt = new System.Windows.Forms.TextBox();
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
            this.lb1.Size = new System.Drawing.Size(73, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "ID Trường";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(12, 46);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(26, 13);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "Tên";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(12, 81);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(52, 13);
            this.lb3.TabIndex = 2;
            this.lb3.Text = "Địa Chỉ";
            // 
            // IDGiangVienTxt
            // 
            this.IDGiangVienTxt.Location = new System.Drawing.Point(93, 2);
            this.IDGiangVienTxt.Name = "IDGiangVienTxt";
            this.IDGiangVienTxt.Size = new System.Drawing.Size(191, 20);
            this.IDGiangVienTxt.TabIndex = 8;
            // 
            // TenTxt
            // 
            this.TenTxt.Location = new System.Drawing.Point(93, 39);
            this.TenTxt.Name = "TenTxt";
            this.TenTxt.Size = new System.Drawing.Size(191, 20);
            this.TenTxt.TabIndex = 9;
            // 
            // IDTruongTxt
            // 
            this.IDTruongTxt.Location = new System.Drawing.Point(93, 74);
            this.IDTruongTxt.Name = "IDTruongTxt";
            this.IDTruongTxt.Size = new System.Drawing.Size(191, 20);
            this.IDTruongTxt.TabIndex = 10;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.IDTruongTxt);
            this.Controls.Add(this.TenTxt);
            this.Controls.Add(this.IDGiangVienTxt);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "Form2";
            this.Text = "Quản lý Giảng Viên";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.TextBox IDGiangVienTxt;
        private System.Windows.Forms.TextBox TenTxt;
        private System.Windows.Forms.TextBox IDTruongTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
    }
}


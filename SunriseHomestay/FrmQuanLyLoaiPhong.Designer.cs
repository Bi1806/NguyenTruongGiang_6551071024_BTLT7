namespace SunriseHomestay
{
    partial class FrmQuanLyLoaiPhong
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMaLoai = new TextBox();
            txtTenLoai = new TextBox();
            txtGiaMoiDem = new TextBox();
            txtMoTa = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            dgvLoaiPhong = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).BeginInit();
            SuspendLayout();
            // 
            // txtMaLoai
            // 
            txtMaLoai.Location = new Point(192, 51);
            txtMaLoai.Name = "txtMaLoai";
            txtMaLoai.ReadOnly = true;
            txtMaLoai.Size = new Size(125, 27);
            txtMaLoai.TabIndex = 0;
            // 
            // txtTenLoai
            // 
            txtTenLoai.Location = new Point(192, 110);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(273, 27);
            txtTenLoai.TabIndex = 1;
            // 
            // txtGiaMoiDem
            // 
            txtGiaMoiDem.Location = new Point(192, 170);
            txtGiaMoiDem.Name = "txtGiaMoiDem";
            txtGiaMoiDem.Size = new Size(273, 27);
            txtGiaMoiDem.TabIndex = 2;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(192, 220);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(280, 68);
            txtMoTa.TabIndex = 3;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(68, 318);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(213, 318);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(363, 318);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(497, 318);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 7;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // dgvLoaiPhong
            // 
            dgvLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiPhong.Location = new Point(100, 380);
            dgvLoaiPhong.MultiSelect = false;
            dgvLoaiPhong.Name = "dgvLoaiPhong";
            dgvLoaiPhong.ReadOnly = true;
            dgvLoaiPhong.RowHeadersWidth = 51;
            dgvLoaiPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiPhong.Size = new Size(625, 218);
            dgvLoaiPhong.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 58);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 9;
            label1.Text = "Mã loại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 110);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 10;
            label2.Text = "Tên loại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 173);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 11;
            label3.Text = "Giá mỗi đêm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 223);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 12;
            label4.Text = "Mô tả:";
            // 
            // FrmQuanLyLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvLoaiPhong);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtMoTa);
            Controls.Add(txtGiaMoiDem);
            Controls.Add(txtTenLoai);
            Controls.Add(txtMaLoai);
            Name = "FrmQuanLyLoaiPhong";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaLoai;
        private TextBox txtTenLoai;
        private TextBox txtGiaMoiDem;
        private TextBox txtMoTa;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private DataGridView dgvLoaiPhong;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}

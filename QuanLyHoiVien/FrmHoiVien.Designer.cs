namespace QuanLyHoiVien
{
    partial class FrmHoiVien
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
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtTimKiem = new TextBox();
            grpGioiTinh = new RadioButton();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            dtpNgaySinh = new DateTimePicker();
            cboHangThanhVien = new ComboBox();
            chkDangHoatDong = new CheckBox();
            btnSua = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnTimKiem = new Button();
            cboLocHang = new ComboBox();
            dgvHoiVien = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHoiVien).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(270, 29);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(150, 27);
            txtHoTen.TabIndex = 0;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(270, 89);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(150, 27);
            txtSDT.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(270, 149);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(32, 341);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(278, 27);
            txtTimKiem.TabIndex = 3;
            // 
            // grpGioiTinh
            // 
            grpGioiTinh.AutoSize = true;
            grpGioiTinh.Location = new Point(444, 29);
            grpGioiTinh.Name = "grpGioiTinh";
            grpGioiTinh.Size = new Size(86, 24);
            grpGioiTinh.TabIndex = 4;
            grpGioiTinh.TabStop = true;
            grpGioiTinh.Text = "Giới tính";
            grpGioiTinh.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(449, 71);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(62, 24);
            rdoNam.TabIndex = 5;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(517, 71);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(50, 24);
            rdoNu.TabIndex = 6;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(270, 212);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(230, 27);
            dtpNgaySinh.TabIndex = 7;
            // 
            // cboHangThanhVien
            // 
            cboHangThanhVien.FormattingEnabled = true;
            cboHangThanhVien.Items.AddRange(new object[] { "Basic", "", "VIP", "", "Premium" });
            cboHangThanhVien.Location = new Point(270, 265);
            cboHangThanhVien.Name = "cboHangThanhVien";
            cboHangThanhVien.Size = new Size(151, 28);
            cboHangThanhVien.TabIndex = 8;
            // 
            // chkDangHoatDong
            // 
            chkDangHoatDong.AutoSize = true;
            chkDangHoatDong.Location = new Point(12, 296);
            chkDangHoatDong.Name = "chkDangHoatDong";
            chkDangHoatDong.Size = new Size(140, 24);
            chkDangHoatDong.TabIndex = 9;
            chkDangHoatDong.Text = "Đang hoạt động";
            chkDangHoatDong.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(626, 71);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(626, 30);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(626, 118);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(626, 164);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 13;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(632, 337);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 14;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // cboLocHang
            // 
            cboLocHang.FormattingEnabled = true;
            cboLocHang.Items.AddRange(new object[] { "Tất cả", "", "Basic", "", "VIP", "", "Premium" });
            cboLocHang.Location = new Point(439, 338);
            cboLocHang.Name = "cboLocHang";
            cboLocHang.Size = new Size(151, 28);
            cboLocHang.TabIndex = 15;
            // 
            // dgvHoiVien
            // 
            dgvHoiVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoiVien.Location = new Point(32, 386);
            dgvHoiVien.MultiSelect = false;
            dgvHoiVien.Name = "dgvHoiVien";
            dgvHoiVien.ReadOnly = true;
            dgvHoiVien.RowHeadersWidth = 51;
            dgvHoiVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoiVien.Size = new Size(652, 188);
            dgvHoiVien.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 34);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 17;
            label1.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 92);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 18;
            label2.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 156);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 19;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 219);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 20;
            label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 273);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 21;
            label5.Text = "Hạng thành viên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(316, 341);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 22;
            label6.Text = "Hạng thành viên";
            // 
            // FrmHoiVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvHoiVien);
            Controls.Add(cboLocHang);
            Controls.Add(btnTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(chkDangHoatDong);
            Controls.Add(cboHangThanhVien);
            Controls.Add(dtpNgaySinh);
            Controls.Add(rdoNu);
            Controls.Add(rdoNam);
            Controls.Add(grpGioiTinh);
            Controls.Add(txtTimKiem);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Name = "FrmHoiVien";
            Text = "FrmHoiVien";
            ((System.ComponentModel.ISupportInitialize)dgvHoiVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtTimKiem;
        private RadioButton grpGioiTinh;
        private RadioButton rdoNam;
        private RadioButton rdoNu;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cboHangThanhVien;
        private CheckBox chkDangHoatDong;
        private Button btnSua;
        private Button btnThem;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnTimKiem;
        private ComboBox cboLocHang;
        private DataGridView dgvHoiVien;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
namespace AnKhangClinic
{
    partial class FrmQuanLyLichKham
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
            txtTenBenhNhan = new TextBox();
            txtSDT = new TextBox();
            dtpNgayKham = new DateTimePicker();
            dtpGioKham = new DateTimePicker();
            cboBacSi = new ComboBox();
            cboTrangThai = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnQuanLyBacSi = new Button();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            cboTimBacSi = new ComboBox();
            btnTimKiem = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dgvLichKham = new DataGridView();
            colMaLich = new DataGridViewTextBoxColumn();
            colTenBenhNhan = new DataGridViewTextBoxColumn();
            colSDTLich = new DataGridViewTextBoxColumn();
            colNgayKham = new DataGridViewTextBoxColumn();
            colGioKham = new DataGridViewTextBoxColumn();
            colBacSi = new DataGridViewTextBoxColumn();
            colChuyenKhoa = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvLichKham).BeginInit();
            SuspendLayout();
            // 
            // txtTenBenhNhan
            // 
            txtTenBenhNhan.Location = new Point(216, 46);
            txtTenBenhNhan.Name = "txtTenBenhNhan";
            txtTenBenhNhan.Size = new Size(125, 27);
            txtTenBenhNhan.TabIndex = 0;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(216, 96);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(125, 27);
            txtSDT.TabIndex = 1;
            // 
            // dtpNgayKham
            // 
            dtpNgayKham.Format = DateTimePickerFormat.Short;
            dtpNgayKham.Location = new Point(216, 160);
            dtpNgayKham.Name = "dtpNgayKham";
            dtpNgayKham.Size = new Size(206, 27);
            dtpNgayKham.TabIndex = 2;
            // 
            // dtpGioKham
            // 
            dtpGioKham.Format = DateTimePickerFormat.Time;
            dtpGioKham.Location = new Point(523, 162);
            dtpGioKham.Name = "dtpGioKham";
            dtpGioKham.ShowUpDown = true;
            dtpGioKham.Size = new Size(250, 27);
            dtpGioKham.TabIndex = 3;
            // 
            // cboBacSi
            // 
            cboBacSi.FormattingEnabled = true;
            cboBacSi.Location = new Point(216, 215);
            cboBacSi.Name = "cboBacSi";
            cboBacSi.Size = new Size(151, 28);
            cboBacSi.TabIndex = 4;
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Chờ khám", "", "Đã khám", "Đã hủy" });
            cboTrangThai.Location = new Point(216, 266);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(151, 28);
            cboTrangThai.TabIndex = 5;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(63, 320);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(199, 320);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(328, 320);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(469, 320);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyBacSi
            // 
            btnQuanLyBacSi.Location = new Point(658, 45);
            btnQuanLyBacSi.Name = "btnQuanLyBacSi";
            btnQuanLyBacSi.Size = new Size(147, 29);
            btnQuanLyBacSi.TabIndex = 10;
            btnQuanLyBacSi.Text = "Quản lý bác sĩ";
            btnQuanLyBacSi.UseVisualStyleBackColor = true;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Location = new Point(482, 385);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(250, 27);
            dtpTuNgay.TabIndex = 11;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(138, 385);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(250, 27);
            dtpDenNgay.TabIndex = 12;
            // 
            // cboTimBacSi
            // 
            cboTimBacSi.FormattingEnabled = true;
            cboTimBacSi.Location = new Point(138, 437);
            cboTimBacSi.Name = "cboTimBacSi";
            cboTimBacSi.Size = new Size(151, 28);
            cboTimBacSi.TabIndex = 13;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(375, 440);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 14;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 44);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 15;
            label1.Text = "Tên bệnh nhân:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 99);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 16;
            label2.Text = "Số điện thoại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 167);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 17;
            label3.Text = "Ngày khám:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 215);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 18;
            label4.Text = "Bác sĩ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 266);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 19;
            label5.Text = "Trạng thái:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(394, 390);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 20;
            label6.Text = "Đến ngày:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(442, 165);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 21;
            label7.Text = "Giờ khám:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(63, 390);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 22;
            label8.Text = "Từ ngày:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(63, 440);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 23;
            label9.Text = "Bác sĩ:";
            // 
            // dgvLichKham
            // 
            dgvLichKham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichKham.Columns.AddRange(new DataGridViewColumn[] { colMaLich, colTenBenhNhan, colSDTLich, colNgayKham, colGioKham, colBacSi, colChuyenKhoa, colTrangThai });
            dgvLichKham.Location = new Point(87, 502);
            dgvLichKham.Name = "dgvLichKham";
            dgvLichKham.RowHeadersWidth = 51;
            dgvLichKham.Size = new Size(645, 188);
            dgvLichKham.TabIndex = 24;
            // 
            // colMaLich
            // 
            colMaLich.DataPropertyName = "MaLich";
            colMaLich.HeaderText = "Mã lịch";
            colMaLich.MinimumWidth = 6;
            colMaLich.Name = "colMaLich";
            colMaLich.Width = 125;
            // 
            // colTenBenhNhan
            // 
            colTenBenhNhan.DataPropertyName = "TenBenhNhan";
            colTenBenhNhan.HeaderText = "Tên bệnh nhân";
            colTenBenhNhan.MinimumWidth = 6;
            colTenBenhNhan.Name = "colTenBenhNhan";
            colTenBenhNhan.Width = 125;
            // 
            // colSDTLich
            // 
            colSDTLich.DataPropertyName = "Sdt";
            colSDTLich.HeaderText = "SĐT";
            colSDTLich.MinimumWidth = 6;
            colSDTLich.Name = "colSDTLich";
            colSDTLich.Width = 125;
            // 
            // colNgayKham
            // 
            colNgayKham.DataPropertyName = "NgayKham";
            colNgayKham.HeaderText = "Ngày khám";
            colNgayKham.MinimumWidth = 6;
            colNgayKham.Name = "colNgayKham";
            colNgayKham.Width = 125;
            // 
            // colGioKham
            // 
            colGioKham.DataPropertyName = "GioKham";
            colGioKham.HeaderText = "Giờ khám";
            colGioKham.MinimumWidth = 6;
            colGioKham.Name = "colGioKham";
            colGioKham.Width = 125;
            // 
            // colBacSi
            // 
            colBacSi.DataPropertyName = "BacSi";
            colBacSi.HeaderText = "Bác sĩ";
            colBacSi.MinimumWidth = 6;
            colBacSi.Name = "colBacSi";
            colBacSi.Width = 125;
            // 
            // colChuyenKhoa
            // 
            colChuyenKhoa.DataPropertyName = "ChuyenKhoa";
            colChuyenKhoa.HeaderText = "Chuyên khoa";
            colChuyenKhoa.MinimumWidth = 6;
            colChuyenKhoa.Name = "colChuyenKhoa";
            colChuyenKhoa.Width = 125;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.Width = 125;
            // 
            // FrmQuanLyLichKham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 605);
            Controls.Add(dgvLichKham);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTimKiem);
            Controls.Add(cboTimBacSi);
            Controls.Add(dtpDenNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(btnQuanLyBacSi);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cboTrangThai);
            Controls.Add(cboBacSi);
            Controls.Add(dtpGioKham);
            Controls.Add(dtpNgayKham);
            Controls.Add(txtSDT);
            Controls.Add(txtTenBenhNhan);
            Name = "FrmQuanLyLichKham";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvLichKham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenBenhNhan;
        private TextBox txtSDT;
        private DateTimePicker dtpNgayKham;
        private DateTimePicker dtpGioKham;
        private ComboBox cboBacSi;
        private ComboBox cboTrangThai;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnQuanLyBacSi;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private ComboBox cboTimBacSi;
        private Button btnTimKiem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DataGridView dgvLichKham;
        private DataGridViewTextBoxColumn colMaLich;
        private DataGridViewTextBoxColumn colTenBenhNhan;
        private DataGridViewTextBoxColumn colSDTLich;
        private DataGridViewTextBoxColumn colNgayKham;
        private DataGridViewTextBoxColumn colGioKham;
        private DataGridViewTextBoxColumn colBacSi;
        private DataGridViewTextBoxColumn colChuyenKhoa;
        private DataGridViewTextBoxColumn colTrangThai;
    }
}

namespace SunriseHomestay
{
    partial class FrmQuanLyPhong
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
            txtMaPhong = new TextBox();
            txtSoPhong = new TextBox();
            nudTangSo = new NumericUpDown();
            cboLoaiPhong = new ComboBox();
            cboTinhTrang = new ComboBox();
            picHinhAnh = new PictureBox();
            btnChonAnh = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnTimKiem = new Button();
            btnLamMoi = new Button();
            cboLocLoaiPhong = new ComboBox();
            cboLocTinhTrang = new ComboBox();
            dgvPhong = new DataGridView();
            colMaPhong = new DataGridViewTextBoxColumn();
            colSoPhong = new DataGridViewTextBoxColumn();
            colTangSo = new DataGridViewTextBoxColumn();
            colLoaiPhong = new DataGridViewTextBoxColumn();
            colTinhTrang = new DataGridViewTextBoxColumn();
            colHinhAnh = new DataGridViewImageColumn();
            btnQuanLyLoaiPhong = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnLoaiPhong = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudTangSo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).BeginInit();
            SuspendLayout();
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(197, 69);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.ReadOnly = true;
            txtMaPhong.Size = new Size(125, 27);
            txtMaPhong.TabIndex = 0;
            // 
            // txtSoPhong
            // 
            txtSoPhong.Location = new Point(505, 68);
            txtSoPhong.Name = "txtSoPhong";
            txtSoPhong.Size = new Size(125, 27);
            txtSoPhong.TabIndex = 1;
            // 
            // nudTangSo
            // 
            nudTangSo.Location = new Point(197, 138);
            nudTangSo.Name = "nudTangSo";
            nudTangSo.Size = new Size(150, 27);
            nudTangSo.TabIndex = 2;
            // 
            // cboLoaiPhong
            // 
            cboLoaiPhong.FormattingEnabled = true;
            cboLoaiPhong.Location = new Point(505, 130);
            cboLoaiPhong.Name = "cboLoaiPhong";
            cboLoaiPhong.Size = new Size(151, 28);
            cboLoaiPhong.TabIndex = 3;
            // 
            // cboTinhTrang
            // 
            cboTinhTrang.FormattingEnabled = true;
            cboTinhTrang.Location = new Point(196, 198);
            cboTinhTrang.Name = "cboTinhTrang";
            cboTinhTrang.Size = new Size(151, 28);
            cboTinhTrang.TabIndex = 4;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(371, 198);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(196, 72);
            picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picHinhAnh.TabIndex = 5;
            picHinhAnh.TabStop = false;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(371, 276);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(94, 29);
            btnChonAnh.TabIndex = 6;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(162, 374);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(37, 374);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(291, 374);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(621, 466);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 10;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(424, 374);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 12;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // cboLocLoaiPhong
            // 
            cboLocLoaiPhong.FormattingEnabled = true;
            cboLocLoaiPhong.Location = new Point(424, 472);
            cboLocLoaiPhong.Name = "cboLocLoaiPhong";
            cboLocLoaiPhong.Size = new Size(151, 28);
            cboLocLoaiPhong.TabIndex = 13;
            // 
            // cboLocTinhTrang
            // 
            cboLocTinhTrang.FormattingEnabled = true;
            cboLocTinhTrang.Location = new Point(134, 472);
            cboLocTinhTrang.Name = "cboLocTinhTrang";
            cboLocTinhTrang.Size = new Size(151, 28);
            cboLocTinhTrang.TabIndex = 14;
            // 
            // dgvPhong
            // 
            dgvPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhong.Columns.AddRange(new DataGridViewColumn[] { colMaPhong, colSoPhong, colTangSo, colLoaiPhong, colTinhTrang, colHinhAnh });
            dgvPhong.Location = new Point(67, 547);
            dgvPhong.MultiSelect = false;
            dgvPhong.Name = "dgvPhong";
            dgvPhong.ReadOnly = true;
            dgvPhong.RowHeadersWidth = 51;
            dgvPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhong.Size = new Size(808, 188);
            dgvPhong.TabIndex = 15;
            // 
            // colMaPhong
            // 
            colMaPhong.DataPropertyName = "MaPhong";
            colMaPhong.HeaderText = "Mã phòng";
            colMaPhong.MinimumWidth = 6;
            colMaPhong.Name = "colMaPhong";
            colMaPhong.ReadOnly = true;
            colMaPhong.Width = 125;
            // 
            // colSoPhong
            // 
            colSoPhong.DataPropertyName = "SoPhong";
            colSoPhong.HeaderText = "Số phòng";
            colSoPhong.MinimumWidth = 6;
            colSoPhong.Name = "colSoPhong";
            colSoPhong.ReadOnly = true;
            colSoPhong.Width = 125;
            // 
            // colTangSo
            // 
            colTangSo.DataPropertyName = "TangSo";
            colTangSo.HeaderText = "Tầng";
            colTangSo.MinimumWidth = 6;
            colTangSo.Name = "colTangSo";
            colTangSo.ReadOnly = true;
            colTangSo.Width = 125;
            // 
            // colLoaiPhong
            // 
            colLoaiPhong.HeaderText = "Loại phòng";
            colLoaiPhong.MinimumWidth = 6;
            colLoaiPhong.Name = "colLoaiPhong";
            colLoaiPhong.ReadOnly = true;
            colLoaiPhong.Width = 125;
            // 
            // colTinhTrang
            // 
            colTinhTrang.DataPropertyName = "TinhTrang";
            colTinhTrang.HeaderText = "Tình trạng";
            colTinhTrang.MinimumWidth = 6;
            colTinhTrang.Name = "colTinhTrang";
            colTinhTrang.ReadOnly = true;
            colTinhTrang.Width = 125;
            // 
            // colHinhAnh
            // 
            colHinhAnh.HeaderText = "Hình ảnh";
            colHinhAnh.MinimumWidth = 6;
            colHinhAnh.Name = "colHinhAnh";
            colHinhAnh.ReadOnly = true;
            colHinhAnh.Width = 125;
            // 
            // btnQuanLyLoaiPhong
            // 
            btnQuanLyLoaiPhong.Location = new Point(12, 12);
            btnQuanLyLoaiPhong.Name = "btnQuanLyLoaiPhong";
            btnQuanLyLoaiPhong.Size = new Size(151, 29);
            btnQuanLyLoaiPhong.TabIndex = 16;
            btnQuanLyLoaiPhong.Text = "Quản lý loại phòng";
            btnQuanLyLoaiPhong.UseVisualStyleBackColor = true;
            btnQuanLyLoaiPhong.Click += btnQuanLyLoaiPhong_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 71);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 17;
            label1.Text = "Mã phòng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 71);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 18;
            label2.Text = "Số phòng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 138);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 19;
            label3.Text = "Tầng số:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(371, 145);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 20;
            label4.Text = "Loại phòng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 198);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 21;
            label5.Text = "Tình trạng:";
            // 
            // btnLoaiPhong
            // 
            btnLoaiPhong.Location = new Point(547, 374);
            btnLoaiPhong.Name = "btnLoaiPhong";
            btnLoaiPhong.Size = new Size(121, 29);
            btnLoaiPhong.TabIndex = 22;
            btnLoaiPhong.Text = "LOẠI PHÒNG";
            btnLoaiPhong.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 472);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 23;
            label6.Text = "Tình trạng:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(329, 475);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 24;
            label7.Text = "Loại phòng:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 422);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 25;
            label8.Text = "Tìm kiếm:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(312, 511);
            label9.Name = "label9";
            label9.Size = new Size(124, 20);
            label9.TabIndex = 26;
            label9.Text = "Danh sách phòng";
            // 
            // FrmQuanLyPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 611);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnLoaiPhong);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnQuanLyLoaiPhong);
            Controls.Add(dgvPhong);
            Controls.Add(cboLocTinhTrang);
            Controls.Add(cboLocLoaiPhong);
            Controls.Add(btnLamMoi);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnChonAnh);
            Controls.Add(picHinhAnh);
            Controls.Add(cboTinhTrang);
            Controls.Add(cboLoaiPhong);
            Controls.Add(nudTangSo);
            Controls.Add(txtSoPhong);
            Controls.Add(txtMaPhong);
            Name = "FrmQuanLyPhong";
            Text = "FrmQuanLyPhong";
            ((System.ComponentModel.ISupportInitialize)nudTangSo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaPhong;
        private TextBox txtSoPhong;
        private NumericUpDown nudTangSo;
        private ComboBox cboLoaiPhong;
        private ComboBox cboTinhTrang;
        private PictureBox picHinhAnh;
        private Button btnChonAnh;
        private Button btnSua;
        private Button btnThem;
        private Button btnXoa;
        private Button btnTimKiem;
        private Button btnLamMoi;
        private ComboBox cboLocLoaiPhong;
        private ComboBox cboLocTinhTrang;
        private DataGridView dgvPhong;
        private DataGridViewTextBoxColumn colMaPhong;
        private DataGridViewTextBoxColumn colSoPhong;
        private DataGridViewTextBoxColumn colTangSo;
        private DataGridViewTextBoxColumn colLoaiPhong;
        private DataGridViewTextBoxColumn colTinhTrang;
        private DataGridViewImageColumn colHinhAnh;
        private Button btnQuanLyLoaiPhong;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnLoaiPhong;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
namespace AnKhangClinic
{
    partial class FrmQuanLyBacSi
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
            txtMaBS = new TextBox();
            txtHoTen = new TextBox();
            txtChuyenKhoa = new TextBox();
            txtSDT = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            dgvBacSi = new DataGridView();
            colMaBS = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colChuyenKhoa = new DataGridViewTextBoxColumn();
            colSDT = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBacSi).BeginInit();
            SuspendLayout();
            // 
            // txtMaBS
            // 
            txtMaBS.Location = new Point(260, 59);
            txtMaBS.Name = "txtMaBS";
            txtMaBS.ReadOnly = true;
            txtMaBS.Size = new Size(125, 27);
            txtMaBS.TabIndex = 0;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(260, 137);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(125, 27);
            txtHoTen.TabIndex = 1;
            // 
            // txtChuyenKhoa
            // 
            txtChuyenKhoa.Location = new Point(260, 196);
            txtChuyenKhoa.Name = "txtChuyenKhoa";
            txtChuyenKhoa.Size = new Size(125, 27);
            txtChuyenKhoa.TabIndex = 2;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(260, 252);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(125, 27);
            txtSDT.TabIndex = 3;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(85, 303);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(209, 303);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(336, 303);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(462, 303);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 7;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // dgvBacSi
            // 
            dgvBacSi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBacSi.Columns.AddRange(new DataGridViewColumn[] { colMaBS, colHoTen, colChuyenKhoa, colSDT });
            dgvBacSi.Location = new Point(85, 355);
            dgvBacSi.MultiSelect = false;
            dgvBacSi.Name = "dgvBacSi";
            dgvBacSi.ReadOnly = true;
            dgvBacSi.RowHeadersWidth = 51;
            dgvBacSi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBacSi.Size = new Size(547, 188);
            dgvBacSi.TabIndex = 8;
            // 
            // colMaBS
            // 
            colMaBS.DataPropertyName = "MaBS";
            colMaBS.HeaderText = "Mã BS";
            colMaBS.MinimumWidth = 6;
            colMaBS.Name = "colMaBS";
            colMaBS.ReadOnly = true;
            colMaBS.Width = 125;
            // 
            // colHoTen
            // 
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.HeaderText = "Họ tên";
            colHoTen.MinimumWidth = 6;
            colHoTen.Name = "colHoTen";
            colHoTen.ReadOnly = true;
            colHoTen.Width = 125;
            // 
            // colChuyenKhoa
            // 
            colChuyenKhoa.DataPropertyName = "ChuyenKhoa";
            colChuyenKhoa.HeaderText = "Chuyên khoa";
            colChuyenKhoa.MinimumWidth = 6;
            colChuyenKhoa.Name = "colChuyenKhoa";
            colChuyenKhoa.ReadOnly = true;
            colChuyenKhoa.Width = 125;
            // 
            // colSDT
            // 
            colSDT.DataPropertyName = "SDT";
            colSDT.HeaderText = "SĐT";
            colSDT.MinimumWidth = 6;
            colSDT.Name = "colSDT";
            colSDT.ReadOnly = true;
            colSDT.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 66);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 9;
            label1.Text = "Mã BS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 137);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 10;
            label2.Text = "Họ tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 196);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 11;
            label3.Text = "Chuyên khoa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(129, 255);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 12;
            label4.Text = "SĐT:";
            // 
            // FrmQuanLyBacSi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvBacSi);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtSDT);
            Controls.Add(txtChuyenKhoa);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaBS);
            Name = "FrmQuanLyBacSi";
            Text = "FrmQuanLyBacSi";
            ((System.ComponentModel.ISupportInitialize)dgvBacSi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaBS;
        private TextBox txtHoTen;
        private TextBox txtChuyenKhoa;
        private TextBox txtSDT;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private DataGridView dgvBacSi;
        private DataGridViewTextBoxColumn colMaBS;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colChuyenKhoa;
        private DataGridViewTextBoxColumn colSDT;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
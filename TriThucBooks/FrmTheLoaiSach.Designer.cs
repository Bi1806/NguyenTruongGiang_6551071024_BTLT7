namespace TriThucBooks
{
    partial class FrmTheLoaiSach
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
            txtMaTL = new TextBox();
            txtTenTheLoai = new TextBox();
            txtMoTa = new TextBox();
            txtTimKiem = new TextBox();
            lblNgayTao = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            dgvTheLoaiSach = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTheLoaiSach).BeginInit();
            SuspendLayout();
            // 
            // txtMaTL
            // 
            txtMaTL.Location = new Point(182, 69);
            txtMaTL.Name = "txtMaTL";
            txtMaTL.ReadOnly = true;
            txtMaTL.Size = new Size(125, 27);
            txtMaTL.TabIndex = 0;
            // 
            // txtTenTheLoai
            // 
            txtTenTheLoai.Location = new Point(233, 135);
            txtTenTheLoai.Name = "txtTenTheLoai";
            txtTenTheLoai.Size = new Size(125, 27);
            txtTenTheLoai.TabIndex = 1;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(233, 189);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(260, 67);
            txtMoTa.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(233, 284);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(402, 27);
            txtTimKiem.TabIndex = 3;
            // 
            // lblNgayTao
            // 
            lblNgayTao.AutoSize = true;
            lblNgayTao.Location = new Point(655, 211);
            lblNgayTao.Name = "lblNgayTao";
            lblNgayTao.Size = new Size(50, 20);
            lblNgayTao.TabIndex = 4;
            lblNgayTao.Text = "label1";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(363, 67);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click_1;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(488, 67);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(611, 67);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(722, 71);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 8;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // dgvTheLoaiSach
            // 
            dgvTheLoaiSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheLoaiSach.Location = new Point(102, 338);
            dgvTheLoaiSach.MultiSelect = false;
            dgvTheLoaiSach.Name = "dgvTheLoaiSach";
            dgvTheLoaiSach.ReadOnly = true;
            dgvTheLoaiSach.RowHeadersWidth = 51;
            dgvTheLoaiSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTheLoaiSach.Size = new Size(648, 188);
            dgvTheLoaiSach.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 75);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 10;
            label1.Text = "Mã thể loại";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 142);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 11;
            label2.Text = "Tên thể loại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 192);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 12;
            label3.Text = "Mô tả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 291);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 13;
            label4.Text = "Tìm kiếm";
            // 
            // FrmTheLoaiSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 491);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvTheLoaiSach);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(lblNgayTao);
            Controls.Add(txtTimKiem);
            Controls.Add(txtMoTa);
            Controls.Add(txtTenTheLoai);
            Controls.Add(txtMaTL);
            Name = "FrmTheLoaiSach";
            Text = "FrmTheLoaiSach";
            Load += FrmTheLoaiSach_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTheLoaiSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaTL;
        private TextBox txtTenTheLoai;
        private TextBox txtMoTa;
        private TextBox txtTimKiem;
        private Label lblNgayTao;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private DataGridView dgvTheLoaiSach;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
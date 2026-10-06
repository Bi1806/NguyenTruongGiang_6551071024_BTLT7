using Microsoft.EntityFrameworkCore;
using QuanLyHoiVien.Models;
using QuanLyHoiVien.Models;

namespace QuanLyHoiVien
{
    public partial class FrmHoiVien : Form
    {
        public FrmHoiVien()
        {
            InitializeComponent();

            // Gắn sự kiện
            Load += FrmHoiVien_Load;
            dgvHoiVien.SelectionChanged += dgvHoiVien_SelectionChanged;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnTimKiem.Click += btnTimKiem_Click;
        }

        // =====================================================
        // 1. KẾT NỐI DATABASE
        // =====================================================

        private FitZoneContext GetContext()
        {
            var options = new DbContextOptionsBuilder<FitZoneContext>()
                .UseSqlServer(
                    "Server=LAPTOP-BHA07K98;Database=FitZone;User Id=sa;Password=123456;TrustServerCertificate=True;")
                .Options;

            return new FitZoneContext(options);
        }


        // =====================================================
        // 2. KHI FORM MỞ
        // =====================================================

        private async void FrmHoiVien_Load(object? sender, EventArgs e)
        {
            // ComboBox hạng thành viên
            cboHangThanhVien.Items.Clear();
            cboHangThanhVien.Items.Add("Basic");
            cboHangThanhVien.Items.Add("VIP");
            cboHangThanhVien.Items.Add("Premium");

            cboHangThanhVien.SelectedIndex = 0;

            // ComboBox lọc
            cboLocHang.Items.Clear();
            cboLocHang.Items.Add("Tất cả");
            cboLocHang.Items.Add("Basic");
            cboLocHang.Items.Add("VIP");
            cboLocHang.Items.Add("Premium");

            cboLocHang.SelectedIndex = 0;

            // Giới tính mặc định
            rdoNam.Checked = true;

            // Trạng thái mặc định
            chkDangHoatDong.Checked = true;

            // Ngày sinh mặc định
            dtpNgaySinh.Value = DateTime.Now.AddYears(-18);

            await LoadData();
        }


        // =====================================================
        // 3. LOAD DỮ LIỆU
        // =====================================================

        private async Task LoadData()
        {
            using var context = GetContext();

            var data = await context.HoiViens
                .OrderBy(x => x.MaHv)
                .ToListAsync();

            dgvHoiVien.DataSource = data;

            // Đổi tên cột cho dễ nhìn
            if (dgvHoiVien.Columns.Count > 0)
            {
                dgvHoiVien.Columns["MaHv"].HeaderText = "Mã HV";
                dgvHoiVien.Columns["HoTen"].HeaderText = "Họ tên";
                dgvHoiVien.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgvHoiVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgvHoiVien.Columns["Sdt"].HeaderText = "Số điện thoại";
                dgvHoiVien.Columns["Email"].HeaderText = "Email";
                dgvHoiVien.Columns["HangThanhVien"].HeaderText = "Hạng thành viên";
                dgvHoiVien.Columns["NgayDangKy"].HeaderText = "Ngày đăng ký";
                dgvHoiVien.Columns["TrangThai"].HeaderText = "Trạng thái";

                dgvHoiVien.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvHoiVien.Columns["NgayDangKy"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
        }


        // =====================================================
        // 4. CHỌN DÒNG TRÊN DATAGRIDVIEW
        // =====================================================

        private void dgvHoiVien_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvHoiVien.CurrentRow == null)
                return;

            if (dgvHoiVien.CurrentRow.DataBoundItem is not HoiVien hoiVien)
                return;

            txtHoTen.Text = hoiVien.HoTen;
            txtSDT.Text = hoiVien.Sdt;
            txtEmail.Text = hoiVien.Email;

            // Giới tính
            if (hoiVien.GioiTinh)
                rdoNam.Checked = true;
            else
                rdoNu.Checked = true;

            // Ngày sinh
            dtpNgaySinh.Value = hoiVien.NgaySinh.ToDateTime(TimeOnly.MinValue);

            // Hạng thành viên
            cboHangThanhVien.SelectedItem = hoiVien.HangThanhVien;

            // Trạng thái
            chkDangHoatDong.Checked = hoiVien.TrangThai;
        }


        // =====================================================
        // 5. KIỂM TRA DỮ LIỆU
        // =====================================================

        private bool KiemTraDuLieu()
        {
            // Họ tên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập họ tên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtHoTen.Focus();
                return false;
            }

            // Số điện thoại
            string sdt = txtSDT.Text.Trim();

            if (string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show(
                    "Vui lòng nhập số điện thoại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSDT.Focus();
                return false;
            }

            if (!sdt.All(char.IsDigit))
            {
                MessageBox.Show(
                    "Số điện thoại chỉ được chứa chữ số!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSDT.Focus();
                return false;
            }

            if (sdt.Length < 9 || sdt.Length > 11)
            {
                MessageBox.Show(
                    "Số điện thoại phải có từ 9 đến 11 chữ số!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSDT.Focus();
                return false;
            }

            // Email
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show(
                    "Vui lòng nhập Email!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();
                return false;
            }

            if (!email.Contains("@"))
            {
                MessageBox.Show(
                    "Email phải chứa ký tự '@'!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();
                return false;
            }

            // Hạng thành viên
            if (cboHangThanhVien.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn hạng thành viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cboHangThanhVien.Focus();
                return false;
            }

            // Tuổi >= 15
            DateOnly ngaySinh = DateOnly.FromDateTime(dtpNgaySinh.Value);
            DateOnly homNay = DateOnly.FromDateTime(DateTime.Today);

            int tuoi = homNay.Year - ngaySinh.Year;

            if (ngaySinh > homNay.AddYears(-tuoi))
            {
                tuoi--;
            }

            if (tuoi < 15)
            {
                MessageBox.Show(
                    "Hội viên phải từ 15 tuổi trở lên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                dtpNgaySinh.Focus();
                return false;
            }

            return true;
        }


        // =====================================================
        // 6. THÊM
        // =====================================================

        private async void btnThem_Click(object? sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            using var context = GetContext();

            var hoiVien = new HoiVien
            {
                HoTen = txtHoTen.Text.Trim(),
                GioiTinh = rdoNam.Checked,
                NgaySinh = DateOnly.FromDateTime(dtpNgaySinh.Value),
                Sdt = txtSDT.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                HangThanhVien = cboHangThanhVien.SelectedItem!.ToString()!,
                TrangThai = chkDangHoatDong.Checked
            };

            context.HoiViens.Add(hoiVien);

            await context.SaveChangesAsync();

            MessageBox.Show(
                "Thêm hội viên thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            await LoadData();

            LamMoi();
        }


        // =====================================================
        // 7. SỬA
        // =====================================================

        private async void btnSua_Click(object? sender, EventArgs e)
        {
            if (dgvHoiVien.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn hội viên cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!KiemTraDuLieu())
                return;

            if (dgvHoiVien.CurrentRow.DataBoundItem is not HoiVien hoiVienDangChon)
                return;

            using var context = GetContext();

            var hoiVien = await context.HoiViens
                .FirstOrDefaultAsync(x => x.MaHv == hoiVienDangChon.MaHv);

            if (hoiVien == null)
            {
                MessageBox.Show(
                    "Không tìm thấy hội viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            hoiVien.HoTen = txtHoTen.Text.Trim();
            hoiVien.GioiTinh = rdoNam.Checked;
            hoiVien.NgaySinh = DateOnly.FromDateTime(dtpNgaySinh.Value);
            hoiVien.Sdt = txtSDT.Text.Trim();
            hoiVien.Email = txtEmail.Text.Trim();
            hoiVien.HangThanhVien = cboHangThanhVien.SelectedItem!.ToString()!;
            hoiVien.TrangThai = chkDangHoatDong.Checked;

            await context.SaveChangesAsync();

            MessageBox.Show(
                "Cập nhật hội viên thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            await LoadData();
        }


        // =====================================================
        // 8. XÓA
        // =====================================================

        private async void btnXoa_Click(object? sender, EventArgs e)
        {
            if (dgvHoiVien.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn hội viên cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (dgvHoiVien.CurrentRow.DataBoundItem is not HoiVien hoiVienDangChon)
                return;

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa hội viên này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            using var context = GetContext();

            var hoiVien = await context.HoiViens
                .FirstOrDefaultAsync(x => x.MaHv == hoiVienDangChon.MaHv);

            if (hoiVien == null)
            {
                MessageBox.Show(
                    "Không tìm thấy hội viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            context.HoiViens.Remove(hoiVien);

            await context.SaveChangesAsync();

            MessageBox.Show(
                "Xóa hội viên thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            await LoadData();

            LamMoi();
        }


        // =====================================================
        // 9. TÌM KIẾM 2 ĐIỀU KIỆN
        // =====================================================

        private async void btnTimKiem_Click(object? sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            string? hang = null;

            if (cboLocHang.SelectedIndex > 0)
            {
                hang = cboLocHang.SelectedItem?.ToString();
            }

            using var context = GetContext();

            var query = context.HoiViens.AsQueryable();

            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                query = query.Where(x =>
                    x.HoTen.Contains(tuKhoa));
            }

            if (!string.IsNullOrWhiteSpace(hang))
            {
                query = query.Where(x =>
                    x.HangThanhVien == hang);
            }

            var data = await query
                .OrderBy(x => x.MaHv)
                .ToListAsync();

            dgvHoiVien.DataSource = data;
        }


        // =====================================================
        // 10. LÀM MỚI
        // =====================================================

        private async void btnLamMoi_Click(object? sender, EventArgs e)
        {
            LamMoi();

            await LoadData();
        }


        // =====================================================
        // 11. XÓA DỮ LIỆU TRÊN FORM
        // =====================================================

        private void LamMoi()
        {
            txtHoTen.Clear();
            txtSDT.Clear();
            txtEmail.Clear();

            rdoNam.Checked = true;

            dtpNgaySinh.Value = DateTime.Now.AddYears(-18);

            cboHangThanhVien.SelectedIndex = 0;

            chkDangHoatDong.Checked = true;

            txtTimKiem.Clear();

            if (cboLocHang.Items.Count > 0)
                cboLocHang.SelectedIndex = 0;

            dgvHoiVien.ClearSelection();
        }
    }
}
using Microsoft.EntityFrameworkCore;
using AnKhangClinic.Models;

namespace AnKhangClinic
{
    public partial class FrmQuanLyLichKham : Form
    {
        public FrmQuanLyLichKham()
        {
            InitializeComponent();

            Load += FrmQuanLyLichKham_Load;
            dgvLichKham.SelectionChanged += dgvLichKham_SelectionChanged;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnTimKiem.Click += btnTimKiem_Click;
            btnQuanLyBacSi.Click += btnQuanLyBacSi_Click;
        }

        private AnKhangClinicContext GetContext()
        {
            var options = new DbContextOptionsBuilder<AnKhangClinicContext>()
                .UseSqlServer(
                    "Server=LAPTOP-BHA07K98;Database=AnKhangClinic;User Id=sa;Password=123456;TrustServerCertificate=True;")
                .Options;

            return new AnKhangClinicContext(options);
        }

        private async void FrmQuanLyLichKham_Load(
            object? sender,
            EventArgs e)
        {
            dtpNgayKham.Format = DateTimePickerFormat.Short;

            dtpGioKham.Format = DateTimePickerFormat.Time;
            dtpGioKham.ShowUpDown = true;

            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Format = DateTimePickerFormat.Short;

            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Chờ khám");
            cboTrangThai.Items.Add("Đã khám");
            cboTrangThai.Items.Add("Đã hủy");
            cboTrangThai.SelectedIndex = 0;

            await LoadBacSi();
            await LoadTimKiemBacSi();
            await LoadData();
        }

        // ============================
        // LOAD BÁC SĨ
        // ============================

        private async Task LoadBacSi()
        {
            using var context = GetContext();

            var data = await context.BacSis
                .OrderBy(x => x.HoTen)
                .ToListAsync();

            var danhSach = data.Select(x => new
            {
                MaBs = x.MaBs,
                HienThi = $"BS. {x.HoTen} - {x.ChuyenKhoa}"
            }).ToList();

            cboBacSi.DataSource = danhSach;
            cboBacSi.DisplayMember = "HienThi";
            cboBacSi.ValueMember = "MaBs";
        }

        // ============================
        // COMBOBOX TÌM KIẾM BÁC SĨ
        // ============================

        private async Task LoadTimKiemBacSi()
        {
            using var context = GetContext();

            var data = await context.BacSis
                .OrderBy(x => x.HoTen)
                .ToListAsync();

            var danhSach = new List<object>
            {
                new
                {
                    MaBs = 0,
                    HienThi = "Tất cả"
                }
            };

            foreach (var bacSi in data)
            {
                danhSach.Add(new
                {
                    MaBs = bacSi.MaBs,
                    HienThi = $"BS. {bacSi.HoTen} - {bacSi.ChuyenKhoa}"
                });
            }

            cboTimBacSi.DataSource = danhSach;
            cboTimBacSi.DisplayMember = "HienThi";
            cboTimBacSi.ValueMember = "MaBs";
            cboTimBacSi.SelectedIndex = 0;
        }

        // ============================
        // LOAD DATA
        // ============================

        private async Task LoadData()
        {
            using var context = GetContext();

            var data = await context.LichKhams
                .Include(x => x.MaBsNavigation)
                .OrderBy(x => x.NgayKham)
                .ThenBy(x => x.GioKham)
                .ToListAsync();

            dgvLichKham.DataSource = null;
            dgvLichKham.DataSource = data;

            MessageBox.Show($"Có {data.Count} lịch khám trong database.");
        }

        // ============================
        // CHỌN DÒNG
        // ============================

        private void dgvLichKham_SelectionChanged(
            object? sender,
            EventArgs e)
        {
            if (dgvLichKham.CurrentRow == null)
                return;

            if (dgvLichKham.CurrentRow.DataBoundItem
                is not LichKham lichKham)
                return;

            txtTenBenhNhan.Text = lichKham.TenBenhNhan;
            txtSDT.Text = lichKham.Sdt;

            dtpNgayKham.Value =
                lichKham.NgayKham.ToDateTime(
                    TimeOnly.MinValue);

            dtpGioKham.Value =
                DateTime.Today.Add(
                    lichKham.GioKham.ToTimeSpan());

            cboBacSi.SelectedValue =
                lichKham.MaBs;

            cboTrangThai.SelectedItem =
                lichKham.TrangThai;
        }

        // ============================
        // KIỂM TRA
        // ============================

        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(
                txtTenBenhNhan.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên bệnh nhân!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTenBenhNhan.Focus();
                return false;
            }

            if (cboBacSi.SelectedValue == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn bác sĩ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cboBacSi.Focus();
                return false;
            }

            if (dtpNgayKham.Value.Date < DateTime.Today)
            {
                MessageBox.Show(
                    "Không được đặt lịch khám vào ngày trong quá khứ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        // ============================
        // THÊM
        // ============================

        private async void btnThem_Click(
            object? sender,
            EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            using var context = GetContext();

            var lichKham = new LichKham
            {
                TenBenhNhan =
                    txtTenBenhNhan.Text.Trim(),

                Sdt =
                    txtSDT.Text.Trim(),

                NgayKham =
                    DateOnly.FromDateTime(
                        dtpNgayKham.Value),

                GioKham =
                    TimeOnly.FromDateTime(
                        dtpGioKham.Value),

                MaBs =
                    Convert.ToInt32(
                        cboBacSi.SelectedValue),

                TrangThai =
                    cboTrangThai.SelectedItem?
                    .ToString() ?? "Chờ khám"
            };

            context.LichKhams.Add(lichKham);

            await context.SaveChangesAsync();

            MessageBox.Show(
                "Thêm lịch khám thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            await LoadData();
            LamMoi();
        }

        // ============================
        // SỬA
        // ============================

        private async void btnSua_Click(
            object? sender,
            EventArgs e)
        {
            if (dgvLichKham.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn lịch khám cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (dgvLichKham.CurrentRow.DataBoundItem
                is not LichKham selected)
                return;

            if (!KiemTraDuLieu())
                return;

            using var context = GetContext();

            var lichKham = await context.LichKhams
                .FirstOrDefaultAsync(
                    x => x.MaLich == selected.MaLich);

            if (lichKham == null)
                return;

            lichKham.TenBenhNhan =
                txtTenBenhNhan.Text.Trim();

            lichKham.Sdt =
                txtSDT.Text.Trim();

            lichKham.NgayKham =
                DateOnly.FromDateTime(
                    dtpNgayKham.Value);

            lichKham.GioKham =
                TimeOnly.FromDateTime(
                    dtpGioKham.Value);

            lichKham.MaBs =
                Convert.ToInt32(
                    cboBacSi.SelectedValue);

            lichKham.TrangThai =
                cboTrangThai.SelectedItem?
                .ToString() ?? "Chờ khám";

            await context.SaveChangesAsync();

            MessageBox.Show(
                "Cập nhật lịch khám thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            await LoadData();
        }

        // ============================
        // XÓA
        // ============================

        private async void btnXoa_Click(
            object? sender,
            EventArgs e)
        {
            if (dgvLichKham.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn lịch khám cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (dgvLichKham.CurrentRow.DataBoundItem
                is not LichKham selected)
                return;

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa lịch khám này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            using var context = GetContext();

            var lichKham = await context.LichKhams
                .FirstOrDefaultAsync(
                    x => x.MaLich == selected.MaLich);

            if (lichKham == null)
                return;

            context.LichKhams.Remove(lichKham);

            await context.SaveChangesAsync();

            MessageBox.Show(
                "Xóa lịch khám thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            await LoadData();
            LamMoi();
        }

        // ============================
        // TÌM KIẾM
        // ============================

        private async void btnTimKiem_Click(
            object? sender,
            EventArgs e)
        {
            DateOnly tuNgay =
                DateOnly.FromDateTime(
                    dtpTuNgay.Value);

            DateOnly denNgay =
                DateOnly.FromDateTime(
                    dtpDenNgay.Value);

            if (tuNgay > denNgay)
            {
                MessageBox.Show(
                    "Từ ngày không được lớn hơn đến ngày!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using var context = GetContext();

            var query = context.LichKhams
                .Include(x => x.MaBsNavigation)
                .AsQueryable();

            query = query.Where(x =>
                x.NgayKham >= tuNgay &&
                x.NgayKham <= denNgay);

            int maBs = Convert.ToInt32(
                cboTimBacSi.SelectedValue);

            if (maBs > 0)
            {
                query = query.Where(x =>
                    x.MaBs == maBs);
            }

            var data = await query
                .OrderBy(x => x.NgayKham)
                .ThenBy(x => x.GioKham)
                .ToListAsync();

            dgvLichKham.DataSource = data;
        }

        // ============================
        // LÀM MỚI
        // ============================

        private async void btnLamMoi_Click(
            object? sender,
            EventArgs e)
        {
            LamMoi();

            await LoadData();
        }

        private void LamMoi()
        {
            txtTenBenhNhan.Clear();
            txtSDT.Clear();

            dtpNgayKham.Value =
                DateTime.Today;

            dtpGioKham.Value =
                DateTime.Today.AddHours(8);

            if (cboBacSi.Items.Count > 0)
                cboBacSi.SelectedIndex = 0;

            if (cboTrangThai.Items.Count > 0)
                cboTrangThai.SelectedIndex = 0;

            dgvLichKham.ClearSelection();
        }

        // ============================
        // QUẢN LÝ BÁC SĨ
        // ============================

        private async void btnQuanLyBacSi_Click(
            object? sender,
            EventArgs e)
        {
            using FrmQuanLyBacSi form =
                new FrmQuanLyBacSi();

            form.ShowDialog();

            await LoadBacSi();
            await LoadTimKiemBacSi();
            await LoadData();
        }
    }
}
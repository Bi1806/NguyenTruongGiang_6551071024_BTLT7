using Microsoft.EntityFrameworkCore;
using AnKhangClinic.Models;

namespace AnKhangClinic
{
    public partial class FrmQuanLyBacSi : Form
    {
        public FrmQuanLyBacSi()
        {
            InitializeComponent();

            Load += FrmQuanLyBacSi_Load;
            dgvBacSi.SelectionChanged += dgvBacSi_SelectionChanged;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
        }

        private AnKhangClinicContext GetContext()
        {
            var options = new DbContextOptionsBuilder<AnKhangClinicContext>()
                .UseSqlServer(
                    "Server=LAPTOP-BHA07K98;Database=AnKhangClinic;User Id=sa;Password=123456;TrustServerCertificate=True;")
                .Options;

            return new AnKhangClinicContext(options);
        }

        private async void FrmQuanLyBacSi_Load(
            object? sender,
            EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            using var context = GetContext();

            var data = await context.BacSis
                .OrderBy(x => x.MaBs)
                .ToListAsync();

            dgvBacSi.DataSource = data;
        }

        private void dgvBacSi_SelectionChanged(
            object? sender,
            EventArgs e)
        {
            if (dgvBacSi.CurrentRow == null)
                return;

            if (dgvBacSi.CurrentRow.DataBoundItem is not BacSi bacSi)
                return;

            txtMaBS.Text = bacSi.MaBs.ToString();
            txtHoTen.Text = bacSi.HoTen;
            txtChuyenKhoa.Text = bacSi.ChuyenKhoa;
            txtSDT.Text = bacSi.Sdt;
        }

        private async void btnThem_Click(
            object? sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập họ tên bác sĩ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtHoTen.Focus();
                return;
            }

            using var context = GetContext();

            var bacSi = new BacSi
            {
                HoTen = txtHoTen.Text.Trim(),
                ChuyenKhoa = txtChuyenKhoa.Text.Trim(),
                Sdt = txtSDT.Text.Trim()
            };

            context.BacSis.Add(bacSi);

            await context.SaveChangesAsync();

            MessageBox.Show(
                "Thêm bác sĩ thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            await LoadData();
            LamMoi();
        }

        private async void btnSua_Click(
            object? sender,
            EventArgs e)
        {
            if (!int.TryParse(txtMaBS.Text, out int maBs))
            {
                MessageBox.Show(
                    "Vui lòng chọn bác sĩ cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập họ tên bác sĩ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using var context = GetContext();

            var bacSi = await context.BacSis
                .FirstOrDefaultAsync(x => x.MaBs == maBs);

            if (bacSi == null)
                return;

            bacSi.HoTen = txtHoTen.Text.Trim();
            bacSi.ChuyenKhoa = txtChuyenKhoa.Text.Trim();
            bacSi.Sdt = txtSDT.Text.Trim();

            await context.SaveChangesAsync();

            MessageBox.Show(
                "Cập nhật bác sĩ thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            await LoadData();
        }

        private async void btnXoa_Click(
            object? sender,
            EventArgs e)
        {
            if (!int.TryParse(txtMaBS.Text, out int maBs))
            {
                MessageBox.Show(
                    "Vui lòng chọn bác sĩ cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa bác sĩ này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            using var context = GetContext();

            var bacSi = await context.BacSis
                .FirstOrDefaultAsync(x => x.MaBs == maBs);

            if (bacSi == null)
                return;

            context.BacSis.Remove(bacSi);

            try
            {
                await context.SaveChangesAsync();

                MessageBox.Show(
                    "Xóa bác sĩ thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                await LoadData();
                LamMoi();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(
                    "Không thể xóa bác sĩ vì bác sĩ này đang có lịch khám!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(
            object? sender,
            EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            txtMaBS.Clear();
            txtHoTen.Clear();
            txtChuyenKhoa.Clear();
            txtSDT.Clear();

            dgvBacSi.ClearSelection();
            txtHoTen.Focus();
        }
    }
}
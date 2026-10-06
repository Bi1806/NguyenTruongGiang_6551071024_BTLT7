using Microsoft.EntityFrameworkCore;
using SunriseHomestay.Models;

namespace SunriseHomestay
{
    public partial class FrmQuanLyLoaiPhong : Form
    {
        public FrmQuanLyLoaiPhong()
        {
            InitializeComponent();

            Load += FrmQuanLyLoaiPhong_Load;
            dgvLoaiPhong.SelectionChanged += dgvLoaiPhong_SelectionChanged;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
        }

        private SunriseHomestayContext GetContext()
        {
            var options = new DbContextOptionsBuilder<SunriseHomestayContext>()
                .UseSqlServer(
                    "Server=LAPTOP-BHA07K98;Database=SunriseHomestay;User Id=sa;Password=123456;TrustServerCertificate=True;")
                .Options;

            return new SunriseHomestayContext(options);
        }

        private async void FrmQuanLyLoaiPhong_Load(object? sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            using var context = GetContext();

            var data = await context.LoaiPhongs
                .OrderBy(x => x.MaLoai)
                .ToListAsync();

            dgvLoaiPhong.DataSource = data;
        }

        private void dgvLoaiPhong_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvLoaiPhong.CurrentRow == null)
                return;

            if (dgvLoaiPhong.CurrentRow.DataBoundItem is not LoaiPhong loaiPhong)
                return;

            txtMaLoai.Text = loaiPhong.MaLoai.ToString();
            txtTenLoai.Text = loaiPhong.TenLoai;
            txtGiaMoiDem.Text = loaiPhong.GiaMoiDem.ToString();
            txtMoTa.Text = loaiPhong.MoTa;
        }

        private async void btnThem_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên loại phòng!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTenLoai.Focus();
                return;
            }

            if (!decimal.TryParse(txtGiaMoiDem.Text, out decimal gia))
            {
                MessageBox.Show(
                    "Giá mỗi đêm không hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtGiaMoiDem.Focus();
                return;
            }

            using var context = GetContext();

            var loaiPhong = new LoaiPhong
            {
                TenLoai = txtTenLoai.Text.Trim(),
                GiaMoiDem = gia,
                MoTa = txtMoTa.Text.Trim()
            };

            context.LoaiPhongs.Add(loaiPhong);

            await context.SaveChangesAsync();

            MessageBox.Show(
                "Thêm loại phòng thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            await LoadData();

            LamMoi();
        }

        private async void btnSua_Click(object? sender, EventArgs e)
        {
            if (dgvLoaiPhong.CurrentRow?.DataBoundItem is not LoaiPhong selected)
            {
                MessageBox.Show(
                    "Vui lòng chọn loại phòng cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại phòng!");
                return;
            }

            if (!decimal.TryParse(txtGiaMoiDem.Text, out decimal gia))
            {
                MessageBox.Show("Giá mỗi đêm không hợp lệ!");
                return;
            }

            using var context = GetContext();

            var loaiPhong = await context.LoaiPhongs
                .FirstOrDefaultAsync(x => x.MaLoai == selected.MaLoai);

            if (loaiPhong == null)
                return;

            loaiPhong.TenLoai = txtTenLoai.Text.Trim();
            loaiPhong.GiaMoiDem = gia;
            loaiPhong.MoTa = txtMoTa.Text.Trim();

            await context.SaveChangesAsync();

            MessageBox.Show(
                "Cập nhật loại phòng thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            await LoadData();
        }

        private async void btnXoa_Click(object? sender, EventArgs e)
        {
            if (dgvLoaiPhong.CurrentRow?.DataBoundItem is not LoaiPhong selected)
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Xóa loại phòng này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            using var context = GetContext();

            var loaiPhong = await context.LoaiPhongs
                .FirstOrDefaultAsync(x => x.MaLoai == selected.MaLoai);

            if (loaiPhong == null)
                return;

            context.LoaiPhongs.Remove(loaiPhong);

            try
            {
                await context.SaveChangesAsync();

                MessageBox.Show(
                    "Xóa thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                await LoadData();
                LamMoi();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(
                    "Không thể xóa loại phòng vì đang có phòng thuộc loại này!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object? sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            txtMaLoai.Clear();
            txtTenLoai.Clear();
            txtGiaMoiDem.Clear();
            txtMoTa.Clear();

            dgvLoaiPhong.ClearSelection();
        }
    }
}
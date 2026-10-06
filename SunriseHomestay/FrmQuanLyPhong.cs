using Microsoft.EntityFrameworkCore;
using System.Drawing;
using SunriseHomestay.Models;

namespace SunriseHomestay
{
    public partial class FrmQuanLyPhong : Form
    {
        private string? tenFileAnh;

        public FrmQuanLyPhong()
        {
            InitializeComponent();

            Load += FrmQuanLyPhong_Load;

            dgvPhong.SelectionChanged += dgvPhong_SelectionChanged;

            btnChonAnh.Click += btnChonAnh_Click;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnTimKiem.Click += btnTimKiem_Click;
        }

        private SunriseHomestayContext GetContext()
        {
            var options = new DbContextOptionsBuilder<SunriseHomestayContext>()
                .UseSqlServer(
                    "Server=LAPTOP-BHA07K98;Database=SunriseHomestay;User Id=sa;Password=123456;TrustServerCertificate=True;")
                .Options;

            return new SunriseHomestayContext(options);
        }

        private async void FrmQuanLyPhong_Load(object? sender, EventArgs e)
        {
            cboTinhTrang.Items.Clear();

            cboTinhTrang.Items.Add("Trống");
            cboTinhTrang.Items.Add("Đang ở");
            cboTinhTrang.Items.Add("Đang dọn");

            cboTinhTrang.SelectedIndex = 0;

            await LoadLoaiPhong();

            await LoadLocLoaiPhong();

            await LoadData();
        }

        // =====================================================
        // LOAD LOẠI PHÒNG CHO COMBOBOX
        // =====================================================

        private async Task LoadLoaiPhong()
        {
            using var context = GetContext();

            var data = await context.LoaiPhongs
                .OrderBy(x => x.TenLoai)
                .ToListAsync();

            cboLoaiPhong.DataSource = data;
            cboLoaiPhong.DisplayMember = "TenLoai";
            cboLoaiPhong.ValueMember = "MaLoai";
        }

        // =====================================================
        // LOAD COMBOBOX LỌC
        // =====================================================

        private async Task LoadLocLoaiPhong()
        {
            using var context = GetContext();

            var data = await context.LoaiPhongs
                .OrderBy(x => x.TenLoai)
                .ToListAsync();

            cboLocLoaiPhong.Items.Clear();
            cboLocLoaiPhong.Items.Add("Tất cả");

            foreach (var item in data)
            {
                cboLocLoaiPhong.Items.Add(item.TenLoai);
            }

            cboLocLoaiPhong.SelectedIndex = 0;

            cboLocTinhTrang.Items.Clear();

            cboLocTinhTrang.Items.Add("Tất cả");
            cboLocTinhTrang.Items.Add("Trống");
            cboLocTinhTrang.Items.Add("Đang ở");
            cboLocTinhTrang.Items.Add("Đang dọn");

            cboLocTinhTrang.SelectedIndex = 0;
        }

        // =====================================================
        // LOAD PHÒNG
        // =====================================================

        private async Task LoadData()
        {
            using var context = GetContext();

            var data = await context.Phongs
                .Include(x => x.MaLoaiNavigation)
                .OrderBy(x => x.MaPhong)
                .ToListAsync();

            dgvPhong.Rows.Clear();

            foreach (var phong in data)
            {
                Image? image = LoadImage(phong.HinhAnh);

                dgvPhong.Rows.Add(
                    phong.MaPhong,
                    phong.SoPhong,
                    phong.TangSo,
                    phong.MaLoaiNavigation?.TenLoai,
                    phong.TinhTrang,
                    image
                );
            }
        }

        // =====================================================
        // LOAD ẢNH
        // =====================================================

        private Image? LoadImage(string? fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                return null;

            string imagePath = Path.Combine(
                Application.StartupPath,
                "Images",
                fileName);

            if (!File.Exists(imagePath))
                return null;

            using FileStream stream = new FileStream(
                imagePath,
                FileMode.Open,
                FileAccess.Read);

            using Image temp = Image.FromStream(stream);

            return new Bitmap(temp);
        }

        // =====================================================
        // CHỌN ẢNH
        // =====================================================

        private void btnChonAnh_Click(object? sender, EventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter =
                "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            dialog.Title = "Chọn ảnh phòng";

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            string imagesFolder = Path.Combine(
                Application.StartupPath,
                "Images");

            Directory.CreateDirectory(imagesFolder);

            string extension = Path.GetExtension(dialog.FileName);

            string newFileName =
                "Phong_" +
                DateTime.Now.ToString("yyyyMMddHHmmssfff") +
                extension;

            string destination =
                Path.Combine(imagesFolder, newFileName);

            File.Copy(dialog.FileName, destination, true);

            tenFileAnh = newFileName;

            using FileStream stream = new FileStream(
                destination,
                FileMode.Open,
                FileAccess.Read);

            using Image temp = Image.FromStream(stream);

            picHinhAnh.Image = new Bitmap(temp);
        }

        // =====================================================
        // CHỌN DÒNG
        // =====================================================

        private async void dgvPhong_SelectionChanged(
            object? sender,
            EventArgs e)
        {
            if (dgvPhong.CurrentRow == null)
                return;

            if (dgvPhong.CurrentRow.Cells["colMaPhong"].Value == null)
                return;

            int maPhong = Convert.ToInt32(
                dgvPhong.CurrentRow.Cells["colMaPhong"].Value);

            using var context = GetContext();

            var phong = await context.Phongs
                .Include(x => x.MaLoaiNavigation)
                .FirstOrDefaultAsync(x => x.MaPhong == maPhong);

            if (phong == null)
                return;

            txtMaPhong.Text = phong.MaPhong.ToString();
            txtSoPhong.Text = phong.SoPhong;

            nudTangSo.Value = phong.TangSo;

            cboLoaiPhong.SelectedValue = phong.MaLoai;

            cboTinhTrang.SelectedItem = phong.TinhTrang;

            tenFileAnh = phong.HinhAnh;

            picHinhAnh.Image = LoadImage(phong.HinhAnh);
        }

        // =====================================================
        // VALIDATE
        // =====================================================

        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtSoPhong.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập số phòng!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSoPhong.Focus();
                return false;
            }

            if (cboLoaiPhong.SelectedValue == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn loại phòng!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (cboTinhTrang.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn tình trạng phòng!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        // =====================================================
        // THÊM
        // =====================================================

        private async void btnThem_Click(object? sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            using var context = GetContext();

            string soPhong = txtSoPhong.Text.Trim();

            bool daTonTai = await context.Phongs
                .AnyAsync(x => x.SoPhong == soPhong);

            if (daTonTai)
            {
                MessageBox.Show(
                    "Số phòng đã tồn tại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var phong = new Phong
            {
                SoPhong = soPhong,
                TangSo = (int)nudTangSo.Value,
                TinhTrang = cboTinhTrang.SelectedItem!.ToString()!,
                HinhAnh = tenFileAnh,
                MaLoai = Convert.ToInt32(cboLoaiPhong.SelectedValue)
            };

            context.Phongs.Add(phong);

            await context.SaveChangesAsync();

            MessageBox.Show(
                "Thêm phòng thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            await LoadData();

            LamMoi();
        }

        // =====================================================
        // SỬA
        // =====================================================

        private async void btnSua_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtMaPhong.Text, out int maPhong))
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa!");
                return;
            }

            if (!KiemTraDuLieu())
                return;

            using var context = GetContext();

            var phong = await context.Phongs
                .FirstOrDefaultAsync(x => x.MaPhong == maPhong);

            if (phong == null)
            {
                MessageBox.Show("Không tìm thấy phòng!");
                return;
            }

            string soPhong = txtSoPhong.Text.Trim();

            bool trungSoPhong = await context.Phongs
                .AnyAsync(x =>
                    x.SoPhong == soPhong &&
                    x.MaPhong != maPhong);

            if (trungSoPhong)
            {
                MessageBox.Show(
                    "Số phòng đã tồn tại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            phong.SoPhong = soPhong;
            phong.TangSo = (int)nudTangSo.Value;
            phong.TinhTrang = cboTinhTrang.SelectedItem!.ToString()!;
            phong.HinhAnh = tenFileAnh;
            phong.MaLoai = Convert.ToInt32(cboLoaiPhong.SelectedValue);

            await context.SaveChangesAsync();

            MessageBox.Show(
                "Cập nhật phòng thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            await LoadData();
        }

        // =====================================================
        // XÓA
        // =====================================================

        private async void btnXoa_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtMaPhong.Text, out int maPhong))
            {
                MessageBox.Show(
                    "Vui lòng chọn phòng cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa phòng này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            using var context = GetContext();

            var phong = await context.Phongs
                .FirstOrDefaultAsync(x => x.MaPhong == maPhong);

            if (phong == null)
                return;

            context.Phongs.Remove(phong);

            await context.SaveChangesAsync();

            MessageBox.Show(
                "Xóa phòng thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            await LoadData();

            LamMoi();
        }

        // =====================================================
        // TÌM KIẾM
        // =====================================================

        private async void btnTimKiem_Click(object? sender, EventArgs e)
        {
            string? tinhTrang = null;
            string? tenLoai = null;

            if (cboLocTinhTrang.SelectedIndex > 0)
            {
                tinhTrang = cboLocTinhTrang.SelectedItem?.ToString();
            }

            if (cboLocLoaiPhong.SelectedIndex > 0)
            {
                tenLoai = cboLocLoaiPhong.SelectedItem?.ToString();
            }

            using var context = GetContext();

            var query = context.Phongs
                .Include(x => x.MaLoaiNavigation)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(tinhTrang))
            {
                query = query.Where(x =>
                    x.TinhTrang == tinhTrang);
            }

            if (!string.IsNullOrWhiteSpace(tenLoai))
            {
                query = query.Where(x =>
                    x.MaLoaiNavigation.TenLoai == tenLoai);
            }

            var data = await query
                .OrderBy(x => x.MaPhong)
                .ToListAsync();

            dgvPhong.Rows.Clear();

            foreach (var phong in data)
            {
                dgvPhong.Rows.Add(
                    phong.MaPhong,
                    phong.SoPhong,
                    phong.TangSo,
                    phong.MaLoaiNavigation?.TenLoai,
                    phong.TinhTrang,
                    LoadImage(phong.HinhAnh)
                );
            }
        }

        // =====================================================
        // LÀM MỚI
        // =====================================================

        private async void btnLamMoi_Click(object? sender, EventArgs e)
        {
            LamMoi();

            await LoadData();
        }

        private void LamMoi()
        {
            txtMaPhong.Clear();
            txtSoPhong.Clear();

            nudTangSo.Value = 1;

            if (cboLoaiPhong.Items.Count > 0)
                cboLoaiPhong.SelectedIndex = 0;

            if (cboTinhTrang.Items.Count > 0)
                cboTinhTrang.SelectedIndex = 0;

            picHinhAnh.Image = null;

            tenFileAnh = null;

            dgvPhong.ClearSelection();
        }

        private void btnQuanLyLoaiPhong_Click(object sender, EventArgs e)
        {
            using var form = new FrmQuanLyLoaiPhong();
            form.ShowDialog();

            _ = LoadLoaiPhong();
        }
    }
}
using Microsoft.EntityFrameworkCore;
using TriThucBooks.Models;

namespace TriThucBooks
{
    public partial class FrmTheLoaiSach : Form
    {
        public FrmTheLoaiSach()
        {
            InitializeComponent();

            Load += FrmTheLoaiSach_Load;

            dgvTheLoaiSach.SelectionChanged += dgvTheLoaiSach_SelectionChanged;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;

            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
        }

        // =====================================================
        // KẾT NỐI DATABASE
        // =====================================================

        private TriThucBooksContext GetContext()
        {
            var options = new DbContextOptionsBuilder<TriThucBooksContext>()
                .UseSqlServer(
                    "Server=LAPTOP-BHA07K98;Database=TriThucBooks;User Id=sa;Password=123456;TrustServerCertificate=True;")
                .Options;

            return new TriThucBooksContext(options);
        }

        // =====================================================
        // LOAD FORM
        // =====================================================

        private async void FrmTheLoaiSach_Load(
            object? sender,
            EventArgs e)
        {
            await LoadData();
        }

        // =====================================================
        // HIỂN THỊ DỮ LIỆU
        // =====================================================

        private async Task LoadData()
        {
            using var context = GetContext();

            var data = await context.TheLoaiSaches
                .OrderBy(x => x.MaTl)
                .ToListAsync();

            dgvTheLoaiSach.DataSource = data;

            if (dgvTheLoaiSach.Columns.Count > 0)
            {
                dgvTheLoaiSach.Columns["MaTl"].HeaderText = "Mã thể loại";
                dgvTheLoaiSach.Columns["TenTheLoai"].HeaderText = "Tên thể loại";
                dgvTheLoaiSach.Columns["MoTa"].HeaderText = "Mô tả";
                dgvTheLoaiSach.Columns["SoLuongSach"].HeaderText = "Số lượng sách";
                dgvTheLoaiSach.Columns["NgayTao"].HeaderText = "Ngày tạo";
            }
        }

        // =====================================================
        // CHỌN DÒNG TRÊN DATAGRIDVIEW
        // =====================================================

        private void dgvTheLoaiSach_SelectionChanged(
            object? sender,
            EventArgs e)
        {
            if (dgvTheLoaiSach.CurrentRow == null)
                return;

            if (dgvTheLoaiSach.CurrentRow.DataBoundItem
                is not TheLoaiSach theLoai)
                return;

            txtMaTL.Text = theLoai.MaTl.ToString();
            txtTenTheLoai.Text = theLoai.TenTheLoai;
            txtMoTa.Text = theLoai.MoTa;

            lblNgayTao.Text =
                theLoai.NgayTao.ToString("dd/MM/yyyy HH:mm:ss");
        }

        // =====================================================
        // THÊM
        // =====================================================

        private async void btnThem_Click(
            object? sender,
            EventArgs e)
        {
            string tenTheLoai = txtTenTheLoai.Text.Trim();
            string moTa = txtMoTa.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenTheLoai))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên thể loại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTenTheLoai.Focus();
                return;
            }

            using var context = GetContext();

            // Kiểm tra trùng tên
            bool daTonTai = await context.TheLoaiSaches
                .AnyAsync(x => x.TenTheLoai == tenTheLoai);

            if (daTonTai)
            {
                MessageBox.Show(
                    "Tên thể loại đã tồn tại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTenTheLoai.Focus();
                return;
            }

            var theLoai = new TheLoaiSach
            {
                TenTheLoai = tenTheLoai,
                MoTa = moTa
            };

            context.TheLoaiSaches.Add(theLoai);

            await context.SaveChangesAsync();

            MessageBox.Show(
                "Thêm thể loại thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            await LoadData();

            ClearInput();
        }

        // =====================================================
        // SỬA
        // =====================================================

        private async void btnSua_Click(
            object? sender,
            EventArgs e)
        {
            if (!int.TryParse(txtMaTL.Text, out int maTL))
            {
                MessageBox.Show(
                    "Vui lòng chọn thể loại cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string tenTheLoai = txtTenTheLoai.Text.Trim();
            string moTa = txtMoTa.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenTheLoai))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên thể loại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTenTheLoai.Focus();
                return;
            }

            using var context = GetContext();

            var theLoai = await context.TheLoaiSaches
                .FirstOrDefaultAsync(x => x.MaTl == maTL);

            if (theLoai == null)
            {
                MessageBox.Show(
                    "Không tìm thấy thể loại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Kiểm tra tên mới có bị trùng không
            bool biTrung = await context.TheLoaiSaches
                .AnyAsync(x =>
                    x.TenTheLoai == tenTheLoai &&
                    x.MaTl != maTL);

            if (biTrung)
            {
                MessageBox.Show(
                    "Tên thể loại đã tồn tại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            theLoai.TenTheLoai = tenTheLoai;
            theLoai.MoTa = moTa;

            await context.SaveChangesAsync();

            MessageBox.Show(
                "Cập nhật thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            await LoadData();
        }

        // =====================================================
        // XÓA
        // =====================================================

        private async void btnXoa_Click(
            object? sender,
            EventArgs e)
        {
            if (!int.TryParse(txtMaTL.Text, out int maTL))
            {
                MessageBox.Show(
                    "Vui lòng chọn thể loại cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa thể loại này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            using var context = GetContext();

            var theLoai = await context.TheLoaiSaches
                .FirstOrDefaultAsync(x => x.MaTl == maTL);

            if (theLoai == null)
            {
                MessageBox.Show(
                    "Không tìm thấy thể loại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            context.TheLoaiSaches.Remove(theLoai);

            try
            {
                await context.SaveChangesAsync();

                MessageBox.Show(
                    "Xóa thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                await LoadData();

                ClearInput();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(
                    "Không thể xóa thể loại vì dữ liệu đang được sử dụng!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // TÌM KIẾM
        // =====================================================

        private async void txtTimKiem_TextChanged(
            object? sender,
            EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            using var context = GetContext();

            var data = await context.TheLoaiSaches
                .Where(x => x.TenTheLoai.Contains(tuKhoa))
                .OrderBy(x => x.MaTl)
                .ToListAsync();

            dgvTheLoaiSach.DataSource = data;
        }

        // =====================================================
        // LÀM MỚI
        // =====================================================

        private async void btnLamMoi_Click(
            object? sender,
            EventArgs e)
        {
            txtTimKiem.Clear();

            ClearInput();

            await LoadData();
        }

        // =====================================================
        // XÓA NỘI DUNG NHẬP
        // =====================================================

        private void ClearInput()
        {
            txtMaTL.Clear();
            txtTenTheLoai.Clear();
            txtMoTa.Clear();
            lblNgayTao.Text = "";

            dgvTheLoaiSach.ClearSelection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
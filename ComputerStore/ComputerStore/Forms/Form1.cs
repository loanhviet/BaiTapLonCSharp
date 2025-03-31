using System.Data;
using System.Data.SqlClient;
using ComputerStore.BLL.Services;
using ComputerStore.Models;

namespace ComputerStore
{
    public partial class Form1 : Form
    {
        private readonly CategoryService _categoryService;
        private readonly ProductService _productService;
        private readonly CustomerService _customerService;

        public Form1()
        {
            InitializeComponent();
            _categoryService = new CategoryService();
            _productService = new ProductService(connectionString);
            _customerService = new CustomerService();
            loadcategories();
            LoadProducts();
            LoadCustomers();
            FillCategoryComboBox();

        }
        string connectionString = @"Data Source=LAPTOP-J4KLRFPG\ANHVIET;Initial Catalog=ComputerStoreDB;Integrated Security=True;TrustServerCertificate=True";

        void loadcategories()
        {
            try
            {
                var categories = _categoryService.GetAllCategories();
                dtvgCategories.DataSource = categories;
                dtvgCategories.Columns["MaLoai"].HeaderText = "Mã Loại";
                dtvgCategories.Columns["TenLoai"].HeaderText = "Tên Loại";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách loại hàng: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void btnCategoriesThem_Click(object sender, EventArgs e)
        {
            try
            {

                string tenLoai = txtCategoriesTen.Text.Trim();


                if (string.IsNullOrWhiteSpace(tenLoai))
                {
                    MessageBox.Show("Tên phân loại không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                var category = new Category
                {
                    TenLoai = tenLoai
                };


                _categoryService.AddCategory(category);


                MessageBox.Show("Thêm phân loại thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);


                loadcategories();
                FillCategoryComboBox();


                txtCategoriesTen.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Lỗi khi thêm phân loại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCategoriesSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtvgCategories.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một phân loại để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maLoai = Convert.ToInt32(dtvgCategories.SelectedRows[0].Cells["MaLoai"].Value);
                string tenLoai = txtCategoriesTen.Text.Trim();

                if (string.IsNullOrWhiteSpace(tenLoai))
                {
                    MessageBox.Show("Tên phân loại không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var category = new Category
                {
                    MaLoai = maLoai,
                    TenLoai = tenLoai
                };

                _categoryService.UpdateCategory(category);

                MessageBox.Show("Cập nhật phân loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadcategories();
                txtCategoriesTen.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtvgCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dtvgCategories.Rows[e.RowIndex];
                    txtCategoriesTen.Text = selectedRow.Cells["TenLoai"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnCategoriesXoa_Click(object sender, EventArgs e)
        {
            try
            {

                if (dtvgCategories.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một phân loại để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                int maLoai = Convert.ToInt32(dtvgCategories.SelectedRows[0].Cells["MaLoai"].Value);


                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phân loại này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    _categoryService.DeleteCategory(maLoai);


                    MessageBox.Show("Xóa phân loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    loadcategories();
                    txtCategoriesTen.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCategoriesSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {

                string keyword = txtCategoriesSearch.Text.Trim();


                List<Category> searchResults = _categoryService.SearchCategories(keyword);


                dtvgCategories.DataSource = searchResults;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProducts()
        {
            try
            {

                var products = _productService.GetAllProducts();


                var displayProducts = products.Select(p => new
                {
                    p.MaHang,
                    p.TenHang,
                    TenLoai = _categoryService.GetCategoryNameById(p.MaLoai), // Lấy tên phân loại
                    p.SoLuongTon,
                    p.GiaBan
                }).ToList();


                dtvgProduct.DataSource = displayProducts;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProductThem_Click(object sender, EventArgs e)
        {
            try
            {

                if (cbbProduct.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn phân loại trước khi thêm sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string tenSanPham = txtProductTen.Text.Trim();
                int soLuongTon = Convert.ToInt32(txtProductSoLuongTon.Text);
                decimal giaBan = Convert.ToDecimal(txtProductGiaBan.Text);
                int maLoai = Convert.ToInt32(cbbProduct.SelectedValue);


                if (string.IsNullOrWhiteSpace(tenSanPham))
                {
                    MessageBox.Show("Tên sản phẩm không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (soLuongTon < 0 || giaBan < 0)
                {
                    MessageBox.Show("Số lượng tồn và giá bán không được nhỏ hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                var product = new Product
                {
                    TenHang = tenSanPham,
                    SoLuongTon = soLuongTon,
                    GiaBan = giaBan,
                    MaLoai = maLoai
                };


                _productService.AddProduct(product);


                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                LoadProducts();


                ClearInputProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputs()
        {
            txtProductTen.Clear();
            txtProductSoLuongTon.Clear();
            txtProductGiaBan.Clear();
            cbbProduct.SelectedIndex = -1;
        }
        private void FillCategoryComboBox()
        {
            try
            {

                var categories = _categoryService.GetAllCategories();


                cbbProduct.DataSource = categories;
                cbbProduct.DisplayMember = "TenLoai";
                cbbProduct.ValueMember = "MaLoai";

                cbbProduct.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách phân loại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtvgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {

                    DataGridViewRow selectedRow = dtvgProduct.Rows[e.RowIndex];


                    txtProductTen.Text = selectedRow.Cells["TenHang"].Value?.ToString();
                    txtProductSoLuongTon.Text = selectedRow.Cells["SoLuongTon"].Value?.ToString();
                    txtProductGiaBan.Text = selectedRow.Cells["GiaBan"].Value?.ToString();


                    string tenLoai = selectedRow.Cells["TenLoai"].Value?.ToString();
                    cbbProduct.SelectedItem = cbbProduct.Items.Cast<Category>()
                                                .FirstOrDefault(c => c.TenLoai == tenLoai);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xử lý sự kiện CellClick: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProductXoa_Click(object sender, EventArgs e)
        {
            try
            {

                if (dtvgProduct.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow selectedRow = dtvgProduct.SelectedRows[0];
                int maHang = Convert.ToInt32(selectedRow.Cells["MaHang"].Value);


                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }


                _productService.DeleteProduct(maHang);


                LoadProducts();
                ClearInputProduct();

                MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProductSua_Click(object sender, EventArgs e)
        {
            try
            {

                if (dtvgProduct.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow selectedRow = dtvgProduct.SelectedRows[0];


                int maHang = Convert.ToInt32(selectedRow.Cells["MaHang"].Value);
                string tenHang = txtProductTen.Text.Trim();
                int maLoai = (int)cbbProduct.SelectedValue;
                int soLuongTon = Convert.ToInt32(txtProductSoLuongTon.Text);
                decimal giaBan = Convert.ToDecimal(txtProductGiaBan.Text);


                var product = new Product
                {
                    MaHang = maHang,
                    TenHang = tenHang,
                    MaLoai = maLoai,
                    SoLuongTon = soLuongTon,
                    GiaBan = giaBan
                };


                _productService.UpdateProduct(product);


                LoadProducts();
                ClearInputProduct();

                MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {

                string keyword = txtProductSearch.Text.Trim();


                var products = _productService.SearchProducts(keyword);


                var displayProducts = products.Select(p => new
                {
                    p.MaHang,
                    p.TenHang,
                    TenLoai = _categoryService.GetCategoryNameById(p.MaLoai),
                    p.SoLuongTon,
                    p.GiaBan
                }).ToList();

                dtvgProduct.DataSource = displayProducts;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputProduct()
        {
            txtProductTen.Clear();
            txtProductSoLuongTon.Clear();
            txtProductGiaBan.Clear();
            cbbProduct.SelectedIndex = -1;
            dtvgProduct.ClearSelection();

        }

        private void LoadCustomers()
        {
            try
            {

                var customers = _customerService.GetAllCustomers();


                dtvgKhachHang.DataSource = customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputsCustomer()
        {
            txtKhachHangTenKH.Clear();
            txtKhachHangDiaChiKH.Clear();
            txtKhachHangSoDTKH.Clear();
            dtvgKhachHang.ClearSelection();
        }

        private void dtvgKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dtvgKhachHang.Rows[e.RowIndex];
                    txtKhachHangTenKH.Text = selectedRow.Cells["TenKH"].Value?.ToString();
                    txtKhachHangDiaChiKH.Text = selectedRow.Cells["DiaChi"].Value?.ToString();
                    txtKhachHangSoDTKH.Text = selectedRow.Cells["SoDienThoai"].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xử lý sự kiện CellClick: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKhachHangThem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenKH = txtKhachHangTenKH.Text.Trim();
                string diaChi = txtKhachHangDiaChiKH.Text.Trim();
                string soDienThoai = txtKhachHangSoDTKH.Text.Trim();
                var customer = new Customer
                {
                    TenKH = tenKH,
                    DiaChi = diaChi,
                    SoDienThoai = soDienThoai
                };
                _customerService.AddCustomer(customer);


                LoadCustomers();


                ClearInputsCustomer();

                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKhachHangSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtvgKhachHang.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một khách hàng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DataGridViewRow selectedRow = dtvgKhachHang.SelectedRows[0];
                int maKH = Convert.ToInt32(selectedRow.Cells["MaKH"].Value);
                string tenKH = txtKhachHangTenKH.Text.Trim();
                string diaChi = txtKhachHangDiaChiKH.Text.Trim();
                string soDienThoai = txtKhachHangSoDTKH.Text.Trim();
                var customer = new Customer
                {
                    MaKH = maKH,
                    TenKH = tenKH,
                    DiaChi = diaChi,
                    SoDienThoai = soDienThoai
                };
                _customerService.UpdateCustomer(customer);
                LoadCustomers();
                ClearInputsCustomer();

                MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKhachHangXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtvgKhachHang.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một khách hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DataGridViewRow selectedRow = dtvgKhachHang.SelectedRows[0];
                int maKH = Convert.ToInt32(selectedRow.Cells["MaKH"].Value);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                _customerService.DeleteCustomer(maKH);
                LoadCustomers();
                ClearInputsCustomer();

                MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKhachHangSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtKhachHangSearch.Text.Trim();
                var customers = _customerService.SearchCustomers(keyword);
                dtvgKhachHang.DataSource = customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

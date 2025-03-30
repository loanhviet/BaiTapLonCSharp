using System.Data;
using System.Data.SqlClient;
using ComputerStore.BLL.Services;
using ComputerStore.Models;

namespace ComputerStore
{
    public partial class Form1 : Form
    {
        private readonly CategoryService _categoryService;

        public Form1()
        {
            InitializeComponent();
            _categoryService = new CategoryService();
            loadcategories();
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

                
                txtCategoriesTen.Clear();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có vấn đề
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
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

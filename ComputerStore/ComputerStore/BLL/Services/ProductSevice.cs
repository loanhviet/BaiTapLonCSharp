using System;
using System.Collections.Generic;
using ComputerStore.DAL.Repositories;
using ComputerStore.Models;

namespace ComputerStore.BLL.Services
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;

        // Constructor
        public ProductService(string connectionString)
        {
            // Không cần truyền chuỗi kết nối nữa
            _productRepository = new ProductRepository();
        }

        // Lấy toàn bộ danh sách sản phẩm
        public List<Product> GetAllProducts()
        {
            try
            {
                return _productRepository.GetAllProducts();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách sản phẩm: {ex.Message}");
            }
        }

        // Thêm sản phẩm mới
        public void AddProduct(Product product)
        {
            try
            {
                ValidateProduct(product); // Kiểm tra tính hợp lệ của sản phẩm
                _productRepository.AddProduct(product);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm sản phẩm: {ex.Message}");
            }
        }

        // Cập nhật thông tin sản phẩm
        public void UpdateProduct(Product product)
        {
            try
            {
                ValidateProduct(product); // Kiểm tra tính hợp lệ của sản phẩm
                _productRepository.UpdateProduct(product);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật sản phẩm: {ex.Message}");
            }
        }

        // Xóa sản phẩm theo mã sản phẩm
        public void DeleteProduct(int maSanPham)
        {
            try
            {
                _productRepository.DeleteProduct(maSanPham);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa sản phẩm: {ex.Message}");
            }
        }

        // Tìm kiếm sản phẩm theo từ khóa
        public List<Product> SearchProducts(string keyword)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(keyword))
                {
                    return GetAllProducts(); // Nếu không có từ khóa, trả về toàn bộ danh sách
                }

                return _productRepository.SearchProducts(keyword);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tìm kiếm sản phẩm: {ex.Message}");
            }
        }

        // Phương thức kiểm tra tính hợp lệ của sản phẩm
        private void ValidateProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("Sản phẩm không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(product.TenHang))
            {
                throw new ArgumentException("Tên sản phẩm không được để trống.");
            }

            if (product.SoLuongTon < 0)
            {
                throw new ArgumentException("Số lượng tồn không được nhỏ hơn 0.");
            }

            if (product.GiaBan < 0)
            {
                throw new ArgumentException("Giá bán không được nhỏ hơn 0.");
            }

            if (product.MaLoai <= 0)
            {
                throw new ArgumentException("Mã phân loại không hợp lệ.");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ComputerStore.Models;

namespace ComputerStore.DAL.Repositories
{
    public class ProductRepository
    {
        private readonly CategoryRepository _categoryRepository;

        public ProductRepository(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public ProductRepository()
        {
        }

        // Lấy toàn bộ danh sách sản phẩm
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT MaHang, TenHang, MaLoai, SoLuongTon, GiaBan FROM MatHang";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    products.Add(new Product
                    {
                        MaHang = Convert.ToInt32(reader["MaHang"]),
                        TenHang = reader["TenHang"].ToString(),
                        MaLoai = Convert.ToInt32(reader["MaLoai"]),
                        SoLuongTon = Convert.ToInt32(reader["SoLuongTon"]),
                        GiaBan = Convert.ToDecimal(reader["GiaBan"])
                    });
                }
            }
            return products;
        }

        // Thêm sản phẩm mới
        public void AddProduct(Product product)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO MatHang (TenHang, MaLoai, SoLuongTon, GiaBan) " +
                               "VALUES (@TenHang, @MaLoai, @SoLuongTon, @GiaBan)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenHang", product.TenHang);
                cmd.Parameters.AddWithValue("@MaLoai", product.MaLoai);
                cmd.Parameters.AddWithValue("@SoLuongTon", product.SoLuongTon);
                cmd.Parameters.AddWithValue("@GiaBan", product.GiaBan);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Cập nhật thông tin sản phẩm
        public void UpdateProduct(Product product)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE MatHang " +
                               "SET TenHang = @TenHang, MaLoai = @MaLoai, SoLuongTon = @SoLuongTon, GiaBan = @GiaBan " +
                               "WHERE MaHang = @MaHang";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHang", product.MaHang);
                cmd.Parameters.AddWithValue("@TenHang", product.TenHang);
                cmd.Parameters.AddWithValue("@MaLoai", product.MaLoai);
                cmd.Parameters.AddWithValue("@SoLuongTon", product.SoLuongTon);
                cmd.Parameters.AddWithValue("@GiaBan", product.GiaBan);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Xóa sản phẩm
        public void DeleteProduct(int maSanPham)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM MatHang WHERE MaHang = @MaHang";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHang", maSanPham);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Tìm kiếm sản phẩm theo tên
        public List<Product> SearchProducts(string keyword)
        {
            List<Product> products = new List<Product>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT MaHang, TenHang, MaLoai, SoLuongTon, GiaBan " +
                               "FROM MatHang WHERE TenHang LIKE @Keyword";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Keyword", $"%{keyword}%");

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    products.Add(new Product
                    {
                        MaHang = Convert.ToInt32(reader["MaHang"]),
                        TenHang = reader["TenHang"].ToString(),
                        MaLoai = Convert.ToInt32(reader["MaLoai"]),
                        SoLuongTon = Convert.ToInt32(reader["SoLuongTon"]),
                        GiaBan = Convert.ToDecimal(reader["GiaBan"])
                    });
                }
            }
            return products;
        }
    }
}
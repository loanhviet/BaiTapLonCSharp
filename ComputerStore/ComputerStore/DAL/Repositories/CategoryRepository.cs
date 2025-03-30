using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerStore.Models;
using System.Data;
using System.Data.SqlClient;

namespace ComputerStore.DAL.Repositories
{
    public class CategoryRepository
    {
        public List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT MaLoai, TenLoai FROM LoaiHang";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    categories.Add(new Category
                    {
                        MaLoai = Convert.ToInt32(reader["MaLoai"]),
                        TenLoai = reader["TenLoai"].ToString()
                    });
                }
            }
            return categories;
        }

        public void AddCategory(Category category)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO LoaiHang (TenLoai) VALUES (@TenLoai)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenLoai", category.TenLoai);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

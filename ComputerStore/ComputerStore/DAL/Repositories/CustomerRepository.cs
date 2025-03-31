using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ComputerStore.DAL;
using ComputerStore.Models;

namespace ComputerStore.DAL.Repositories
{
    public class CustomerRepository
    {
        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT MaKH, TenKH, DiaChi, SoDienThoai FROM KhachHang";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    customers.Add(new Customer
                    {
                        MaKH = Convert.ToInt32(reader["MaKH"]),
                        TenKH = reader["TenKH"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        SoDienThoai = reader["SoDienThoai"].ToString()
                    });
                }
            }
            return customers;
        }


        public void AddCustomer(Customer customer)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO KhachHang (TenKH, DiaChi, SoDienThoai) " +
                               "VALUES (@TenKH, @DiaChi, @SoDienThoai)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenKH", customer.TenKH);
                cmd.Parameters.AddWithValue("@DiaChi", customer.DiaChi);
                cmd.Parameters.AddWithValue("@SoDienThoai", customer.SoDienThoai);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public void UpdateCustomer(Customer customer)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE KhachHang " +
                               "SET TenKH = @TenKH, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai " +
                               "WHERE MaKH = @MaKH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKH", customer.MaKH);
                cmd.Parameters.AddWithValue("@TenKH", customer.TenKH);
                cmd.Parameters.AddWithValue("@DiaChi", customer.DiaChi);
                cmd.Parameters.AddWithValue("@SoDienThoai", customer.SoDienThoai);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public void DeleteCustomer(int maKH)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKH", maKH);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public List<Customer> SearchCustomers(string keyword)
        {
            List<Customer> customers = new List<Customer>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT MaKH, TenKH, DiaChi, SoDienThoai " +
                               "FROM KhachHang WHERE TenKH LIKE @Keyword OR SoDienThoai LIKE @Keyword";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Keyword", $"%{keyword}%");

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    customers.Add(new Customer
                    {
                        MaKH = Convert.ToInt32(reader["MaKH"]),
                        TenKH = reader["TenKH"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        SoDienThoai = reader["SoDienThoai"].ToString()
                    });
                }
            }
            return customers;
        }
    }
}
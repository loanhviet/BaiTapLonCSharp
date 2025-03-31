using System;
using System.Collections.Generic;
using ComputerStore.DAL.Repositories;
using ComputerStore.Models;

namespace ComputerStore.BLL.Services
{
    public class CustomerService
    {
        private readonly CustomerRepository _customerRepository;

        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
        }

        public List<Customer> GetAllCustomers()
        {
            try
            {
                return _customerRepository.GetAllCustomers();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách khách hàng: {ex.Message}");
            }
        }


        public void AddCustomer(Customer customer)
        {
            try
            {
                ValidateCustomer(customer);
                _customerRepository.AddCustomer(customer);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm khách hàng: {ex.Message}");
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            try
            {
                ValidateCustomer(customer); 
                _customerRepository.UpdateCustomer(customer);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật khách hàng: {ex.Message}");
            }
        }

        public void DeleteCustomer(int maKH)
        {
            try
            {
                if (maKH <= 0)
                {
                    throw new ArgumentException("Mã khách hàng không hợp lệ.");
                }

                _customerRepository.DeleteCustomer(maKH);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa khách hàng: {ex.Message}");
            }
        }
        public List<Customer> SearchCustomers(string keyword)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(keyword))
                {
                    return GetAllCustomers(); 
                }

                return _customerRepository.SearchCustomers(keyword);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tìm kiếm khách hàng: {ex.Message}");
            }
        }
        private void ValidateCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException("Khách hàng không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(customer.TenKH))
            {
                throw new ArgumentException("Tên khách hàng không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(customer.SoDienThoai))
            {
                throw new ArgumentException("Số điện thoại không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(customer.DiaChi))
            {
                throw new ArgumentException("Địa chỉ không được để trống.");
            }
        }
    }
}
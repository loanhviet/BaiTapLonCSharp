using System;
using System.Collections.Generic;
using ComputerStore.DAL.Repositories;
using ComputerStore.Models;

namespace ComputerStore.BLL.Services
{
    public class CategoryService
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoryService()
        {
            _categoryRepository = new CategoryRepository();
        }

        public List<Category> GetAllCategories()
        {
            return _categoryRepository.GetAllCategories();
        }

        public void AddCategory(Category category)
        {
            if (string.IsNullOrWhiteSpace(category.TenLoai))
            {
                throw new ArgumentException("Category name cannot be empty.");
            }

            _categoryRepository.AddCategory(category);
        }

        public void UpdateCategory(Category category)
        {
            if (category.MaLoai <= 0)
            {
                throw new ArgumentException("Invalid category ID.");
            }

            if (string.IsNullOrWhiteSpace(category.TenLoai))
            {
                throw new ArgumentException("Category name cannot be empty.");
            }

            _categoryRepository.UpdateCategory(category);
        }

        public void DeleteCategory(int maLoai)
        {
            if (maLoai <= 0)
            {
                throw new ArgumentException("Invalid category ID.");
            }

            _categoryRepository.DeleteCategory(maLoai);
        }
        public List<Category> SearchCategories(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return GetAllCategories();
            }

            return _categoryRepository.SearchCategories(keyword);
        }
        public string GetCategoryNameById(int maLoai)
        {
            try
            {
                return _categoryRepository.GetCategoryNameById(maLoai);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy tên phân loại: {ex.Message}");
            }
        }

    }
}

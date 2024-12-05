using MauiAppProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MauiAppProject.Data
{
    public class CourseCategoryRepository : ICourseCategory
    {

        private readonly HttpClient _httpClient;
        public CourseCategoryRepository(HttpClient httpClient) 
        {
            _httpClient = httpClient;
        
        }

        public Task<CourseCategory> AddAsync(CourseCategory courseCategory)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CourseCategory> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CourseCategory>> ListAsync()
        {
            var response = await _httpClient.GetAsync($"{HttpHelper.baseAddress}/api/v1/Categories");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var category = JsonSerializer.Deserialize<List<CourseCategory>>(content,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = false });
                return category ?? new List<CourseCategory>();

            }
            else {
                throw new ArgumentException("Cannot Get Data From Server");
            }
        }

        public Task<CourseCategory> UpdateAsync(CourseCategory courseCategory)
        {
            throw new NotImplementedException();
        }
    }
}

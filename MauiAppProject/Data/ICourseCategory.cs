using MauiAppProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppProject.Data
{
    public interface ICourseCategory
    {
        Task<List<CourseCategory>> ListAsync();
        Task<CourseCategory> GetAsync(int id);
        Task<CourseCategory> AddAsync(CourseCategory courseCategory);
        Task<CourseCategory> UpdateAsync(CourseCategory courseCategory);
        Task DeleteAsync(int id);
    }
}

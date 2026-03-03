using Microsoft.EntityFrameworkCore;

namespace StudentPortalDemo.Models.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public async Task<List<Student>> GetAllAsync(string q = null)
        {
            using (var context = new StudentPortalDbContext())
            {
                var query = context.Students.AsQueryable();
                if (!string.IsNullOrEmpty(q))
                {
                    query = query.Where(s => s.FullName.Contains(q) || s.Email.Contains(q));
                }
                return await query.ToListAsync();
            }
        }
    }
}

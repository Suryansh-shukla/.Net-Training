namespace StudentPortalDemo.Models.Repositories
{
    public interface IStudentRepository
    {
        public Task<List<Student>> GetAllAsync(string q = null);
    }
}

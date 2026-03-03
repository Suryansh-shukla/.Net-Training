namespace StudentPortalDemo.Models.Repositories
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repo;
        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }
        public async Task<(bool ok, string message)> CreateAsync(Student student)
        {
            if (string.IsNullOrWhiteSpace(student.FullName) || string.IsNullOrWhiteSpace(student.Email) || string.IsNullOrWhiteSpace(student.Status))
            {
                return (false, "FullName, Email and Status are required.");
            }

            var exist = await _repo.EmailExistAsync(student.Email);
            if (exist)
            {
                return (false, "Email already exists.");
            }
            //student.Status ??= "Active";

            return (true, "Student created successfully.");
            //throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            if (id <= 0)
            {
                return Task.FromException(new ArgumentException("Invalid student ID."));
            }


            throw new NotImplementedException();
        }

        public Task<Student> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Student>> SearchAsync(string q = null) => _repo.GetAllAsync(q);


        public Task<(bool ok, string message)> UpdateAsync(Student student)
        {
            throw new NotImplementedException();
        }
    }
}

namespace Custom_Words_restriction_App.Models
{
    public interface IRepo
    {
        List<Student> GetAllStudent();
        Student GetStudentById(int id);
        bool AddStudent(Student student);
        bool UpdateStudent(Student student);
        bool DeleteStudent(int id);
    }
}
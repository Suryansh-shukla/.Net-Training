namespace MVC_Core_Web_App.Models
{
    public class StudentRepo : IRepo<Student>
    {
        public static List<Student> studList = new List<Student>();
        public StudentRepo()
        {
            if (studList.Count == 0)
            {
                //Collection Initializer
                studList = new List<Student>()
                {
                    new Student(){RollNo=101,Name="Alok",Age=25,Address="Pune"},
                    new Student(){RollNo=102,Name="Amit",Age=22,Address="Mumbai"},
                    new Student(){RollNo=103,Name="Ankit",Age=28,Address="Delhi"},
                    new Student(){RollNo=104,Name="Riya",Age=24,Address="Bangalore"},
                };
            }
        }
        public bool AddData(Student obj)
        {

            bool flag = false;
            if(obj != null)
            {
                studList.Add(obj);
                flag = true;
            }
            else
            {
                throw new NullReferenceException("Object is not Initialized");
            }
            return flag;
        }

        public bool DeleteData(int id)
        {
            Student? sObj = studList.Find(s => s.RollNo == id);
            if (sObj != null)
            {
                studList.Remove(sObj);
                return true;
            }
            return false;
            //throw new NotImplementedException();
        }

        public List<Student> ShowAllData()
        {
            return studList;
            //throw new NotImplementedException();
        }

        public Student ShowDetailsByID(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid Student ID", nameof(id));

            var student = studList.FirstOrDefault(s => s.RollNo == id);

            if (student is null)
                throw new KeyNotFoundException($"Student with RollNo {id} not found.");

            return student;


            //throw new NotImplementedException();
        }

        public bool UpdateData(int id, Student obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            var student = studList.FirstOrDefault(s => s.RollNo == id);

            if (student == null)
                return false;

            student.Name = obj.Name;
            student.Address = obj.Address;
            student.Age = obj.Age;

            return true;
            //throw new NotImplementedException();
        }
    }
}

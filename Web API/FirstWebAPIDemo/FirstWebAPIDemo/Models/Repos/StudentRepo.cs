namespace FirstWebAPIDemo.Models.Repos
{
    public class StudentRepo : IRepos<Student>
    {
        public static List<Student> studList = null;
        public StudentRepo()
        {
            if (studList == null)
            {
                studList=new List<Student>() 
                { 
                    new Student(){RollNo=101,Name="Alok",City="Phagwara",Phone="8758895155"}, 
                    new Student() {RollNo=102,Name="Naina",City="Amritsar",Phone="9343239798"},
                };
            }
        }
        public bool Add(Student item)
        {
            bool flag = false;

            if (item != null)
            {
                Student? stud = studList.Find(s => s.RollNo == item.RollNo);

                if (stud == null)
                {
                    studList.Add(item);
                    flag = true;
                }
            }

            return flag;
        }

        public bool Delete(int id)
        {
            bool flag = false;
            Student? stud=studList.Find(s=> s.RollNo == id);
            if(stud!=null)
            {
                studList.Remove(stud);
                flag = true;
            }
            return flag;
            //throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            Student? stud=studList.Find(s=>s.RollNo==id);
            if(stud!=null)
            {
                return stud;
            }
            else
            {
                throw new Exception("Student Record Not Available");
            }
            //throw new NotImplementedException();
        }

        public ICollection<Student> GetAll()
        {
            return studList;
            //throw new NotImplementedException();
        }

        public bool Update(int id, Student item)
        {
            bool flag = false;
            Student? stud = studList.Find(s => s.RollNo == item.RollNo);
            if (stud != null && item != null)
            {
                stud.Name = item.Name;
                stud.City = item.City;
                stud.Phone = item.Phone;
                flag = true;
            }
            
            return flag;
        }
    }
}

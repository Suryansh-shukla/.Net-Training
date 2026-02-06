using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConArchDemo
{
    internal class StudentDAL
    {

        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader sdr = null;
        public StudentDAL()
        {
            string conStr = "Data Source=.;Initial Catalog=LPU_Db;Integrated Security=True;";
            conn = new SqlConnection("");
            conn.ConnectionString = "Server=.\\SQLEXPRESS;Integrated Securtiy= SSPI;Database=LPU_Db;Trusted_Connection=True;TrustServerCertificate=true;";
            

        }
        public List<Student> ShowAllStudents()
        {
            List<Student> studList= null;
            //Code for Connected Architecture below
            try
            {
                cmd= new SqlCommand();
                cmd.CommandText = "Select * from StudentsInfo";
                cmd.Connection = conn;
            }
            catch (Exception e)
            {
            }
            finally
            {

                return studList;
            }
        }
        public List<Student> SearchByName(string name)
        {
            List<Student> studList= null;
            return studList;
        }

        public Student SearchByRollNo(int rollno)
        {
            List<Student> studList = null;
            return studList;
        }
    }
}

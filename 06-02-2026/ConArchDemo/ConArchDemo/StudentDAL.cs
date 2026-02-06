using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
            conn = new SqlConnection();
            conn.ConnectionString = "Server=.\\SQLEXPRESS;Integrated Security= SSPI;Database=LPU_Db;Trusted_Connection=True;TrustServerCertificate=true;";
            

        }
        public List<Student> ShowAllStudents()
        {
            List<Student> studList= null;
            //Code for Connected Architecture below
            try
            {
                conn.Open();
                cmd= new SqlCommand();
                cmd.CommandText = "Select * from StudentInfo";
                cmd.Connection = conn;
                cmd.CommandType=CommandType.Text;

                //Holding Data via Reader in forward only control
                sdr=cmd.ExecuteReader();

                DataTable dt = new DataTable();
                
                dt.Load(sdr);
                if (dt.Rows.Count > 0)
                {
                    studList = new List<Student>();

                }
                //Convert Table into List of Student Objects
                foreach (DataRow dr in dt.Rows)
                {
                    Student sObj = new Student()
                    {
                        RollNo = Convert.ToInt32(dr[0].ToString()),
                        Name= dr[1].ToString(),
                        Address= dr[3].ToString(),
                        PhoneNo = dr[5].ToString()
                    };
                    if (sObj != null)
                    {
                        studList.Add(sObj); 
                    }
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {

            }
            return studList;
        }
        public List<Student> SearchByName(string name)
        {
            List<Student> studList= null;
            return studList;
        }

        //public Student SearchByRollNo(int rollno)
        //{
        //    List<Student> studList = null;
        //    return studList;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace MyDemoWebService
{
    /// <summary>
    /// Summary description for LPUWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
     //To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     //[System.Web.Script.Services.ScriptService]
    public class LPUWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public int AddMe(int num1,int num2)
        {
            return num1 + num2;
        }
        [WebMethod]
        public Product[] ShowAllProducts()
        {
            //Connection
            SqlConnection  conn=new SqlConnection();
            conn.ConnectionString= "Server=.\\sqlexpress;Database=LPU_Db;Trusted_Connection=True;TrustServerCertificate=true;";
            conn.Open();

            //Command
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Products";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            //DataReader
            SqlDataReader reader = cmd.ExecuteReader();
            Product[] ProdList = null;
            DataTable dt=new DataTable();
            dt.Load(reader);
            if (dt.Rows.Count>0)
            {
                ProdList = new Product[dt.Rows.Count];
            }
            int count = 0;
            foreach (DataRow item in dt.Rows)
            {
               Product pObj=new Product();
                pObj.ProdId = Convert.ToInt32(item["ProdId"]);
                pObj.Name = item["Name"].ToString();
                pObj.Category = item["Category"].ToString();
                pObj.Price = Convert.ToDecimal(item["Price"]);
                pObj.Description = item["Desc"].ToString();
                ProdList[count] = pObj;
                count++;
            }
            conn.Close();
            return ProdList;
        }
    }
}

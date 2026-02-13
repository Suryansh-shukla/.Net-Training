using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WinFormDisconnArchDemo
{
    class ProductUtility : IProductRepo
    {
        IDbConnection con;
        SqlDataAdapter adap1;
        DataSet ds;
        public ProductUtility()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=.\\sqlexpress;Integrated Security=true;Database=LPU_Db;TrustServerCertificate=true";
            
        }
        public bool AddData(Product data)
        {
            if(data == null) { return false; }
            
            return false;
            //throw new NotImplementedException();
        }

        public bool DeleteData(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetTop3BudgetProduct()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetTop3CostlyProduct()
        {
            throw new NotImplementedException();
        }

        public Product SeachById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> ShowAllData()
        {
            adap1=new SqlDataAdapter("select * from Products", (SqlConnection)con);
            List<Product> prodList = null;
            adap1.MissingSchemaAction = MissingSchemaAction.AddWithKey; 
            ds = new DataSet(); 
            adap1.Fill(ds, "Products");
            if (ds.Tables[0].Rows.Count > 0)
            {
                prodList = new List<Product>();
                foreach (DataRow dr in ds.Tables["Products"].Rows)
                {
                    Product p = new Product()
                    {
                        ProdId = Convert.ToInt32(dr["ProdId"]),
                        ProdName = dr["Name"].ToString(),
                        Price = Convert.ToInt32(dr["Price"]),
                        Desc = dr["Desc"].ToString()
                    };
                    prodList.Add(p);
                }
            }
            return prodList;

            //throw new NotImplementedException();
        }

        public List<Product> ShowAllProductByCategory(int catID)
        {
            throw new NotImplementedException();
        }

        public List<Product> ShowProductByPriceAsc()
        {
            throw new NotImplementedException();
        }

        public List<Product> ShowProductByPriceDesc()
        {
            throw new NotImplementedException();
        }

        public bool UpdateData(int id, Product data)
        {
            throw new NotImplementedException();
        }
    }
}

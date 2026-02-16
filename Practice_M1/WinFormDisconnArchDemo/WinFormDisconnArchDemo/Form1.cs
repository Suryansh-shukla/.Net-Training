using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDisconnArchDemo
{
    public partial class Form1 : Form
    {
        DataTable myDt ;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {

        }

        private void btnShowAllProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductUtility prodObj=new ProductUtility();
            dataGridView1.DataSource=prodObj.ShowAllData();

            ProductUtility pUtil=new ProductUtility();
            myDt = pUtil.ShowAllData(); 


            //Binding UI Elements with Table Column
            txtProdID.DataBindings.Add("Text", dataGridView1.DataSource, "ProdID");
            txtProdName.DataBindings.Add("Text", dataGridView1.DataSource, "Name");
            txtPrice.DataBindings.Add("Text", dataGridView1.DataSource, "Price");
            txtDesc.DataBindings.Add("Text", dataGridView1.DataSource, "Desc");
            //this.DataBindings.Add(ToString(), dataGridView1.DataSource, "CategoryID");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.BindingContext[dataGridView1.DataSource].Position = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //go to last data row
            this.BindingContext[myDt].Position= myDt.Rows.Count-1;
        }
    }
}

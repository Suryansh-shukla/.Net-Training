using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinReflectionDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string FileName = openFileDialog1.FileName;
            Assembly assemblyObj= Assembly.LoadFrom(FileName);
            Type[] typeObj = assemblyObj.GetTypes();
            this.ReflectAll(typeObj[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }
        public void ReflectAll(Type typeObj)
        {
            // Getting all the methods of the type
            MethodInfo[] methodList = typeObj.GetMethods();

            // Getting all the properties of the type
            PropertyInfo[] propList = typeObj.GetProperties();

            //Load All Properties
            foreach(var item in propList)
            {
                listBox1.Items.Add(item.Name);
            }
            foreach(var item in methodList)
            {
                listBox2.Items.Add(item.Name);
            }
            ConstructorInfo[] ctorList = typeObj.GetConstructors();
        }

    }
}

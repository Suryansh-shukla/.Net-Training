using System;
using System.Collections.Generic;
using System.Text;

namespace IndexerDemo
{
    class Project:IEnumerable<Developer>
    {
        public IEnumerator<Developer> GetEnumerator()
        {
            for (int i = 0; i < devList.Length; i++)
            {
                yield return devList[i];
            }
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return devList.GetEnumerator();
        }
        Developer[] devList = null;
        public Project() 
        {
            devList = new Developer[4];
        }
        //Indexer
        public Developer this[int cnt]
        {
            get
            {
                return devList[cnt]; 
            }
            set 
            { 
                devList[cnt] = value; 
            }
        }
    }
    class Developer
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }
     class DemoOnIndexer
    {
        static void IndexerMain()
        {
            Project hsbcProj=new Project();
            hsbcProj[0]=new Developer() { ID=101,Name="Alok"};
            hsbcProj[1] = new Developer() { ID = 456, Name = "Rakshas" };
            hsbcProj[2] = new Developer() { ID = 307, Name = "Buddy" };
            hsbcProj[3] = new Developer() { ID = 107, Name = "Balidaan" };
            foreach(var item in hsbcProj)
            {
                Console.WriteLine($"ID: {item.ID}, Name: {item.Name}");
            }
        }
    }
}

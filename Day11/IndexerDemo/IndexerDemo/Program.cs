using System;
namespace IndexerDemo
{
    class HappyTrip
    {
        string[] emps = new string[5];
        //Indexer
        public string this[int cnt]
        {
            get
            {
                return emps[cnt];
            }
            set
            {
                emps[cnt] = value;
            }
        }
    }
}
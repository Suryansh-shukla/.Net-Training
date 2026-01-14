using ServiceLibrary.ServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    public class SomeLogic
    {
        #region Attributes
        int id;
        string name;
        string addr;
        #endregion


        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Addr
        {
            get { return addr; }
            set { addr = value; }
        }
        #endregion
       

        #region Constructors
        public SomeLogic()
        {

        }
        public SomeLogic(int id, string name, string addr)
        {
            this.id = id;
            this.name = name;
            this.addr = addr;
        }
        #endregion


        #region Methods
        public int AddMe(int num1,int num2)
        {
            return num1 + num2;
        }
        public List<object> ShowAll()
        {
            return new List<object>(); 
        }
        public List<Player> ShowAllPlayers()
        { 
            return new List<Player>() 
            { 
               new Player(){ PlayerId = 1, PlayerName = "Virat Kohli", Skills = { "Batsmen", "Fielder", "Right-arm Fast Bowler" } } ,
               new Player(){ PlayerId = 2, PlayerName = "Rohit Sharma", Skills = { "Batsmen", "Fielder", "Right-arm Fast Bowler" } } ,
               new Player(){ PlayerId = 3, PlayerName = "Jaspreet Bumraah", Skills = { "Fast Bowler", "Fielder", "Right Hand Batsmen" } } ,
               new Player(){ PlayerId = 4, PlayerName = "Mahendra Singh Dhoni", Skills = { "Batsmen", "Wicket Keeper" } } 
            };
        }
        #endregion
    }
}

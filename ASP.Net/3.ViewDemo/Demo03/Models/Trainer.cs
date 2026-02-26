using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo03.Models
{
    public class Trainer
    {
        public string TrainerName { get; set; }
        public string Technology { get; set; }
    }


    public class TrainerService
    {
        private static List<Trainer> trainerList = null;

        static TrainerService()
        {
            trainerList = new List<Trainer>();
            trainerList.Add(new Trainer { TrainerName = "Ganesh", Technology = "<i>Dotnet Trainer</i>" });
            trainerList.Add(new Trainer { TrainerName = "Mohan", Technology = "<i>JEE Trainer</i>" });
        }

        public List<Trainer> GetTrainers()
        {
            return trainerList;
        }


    }
}
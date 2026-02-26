using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelsDemo.Models
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        public string TrainerName { get; set; }
        public Technology Subject { get; set; }
        public Designation Level { get; set; }
    }
}
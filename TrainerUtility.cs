using System;
using System.Collections.Generic;
using System.Linq;
using mis_221_pa_5_swbroadhead;
using System.Threading.Tasks;

namespace Utility
{
    public class TrainerUtility
    {
        public Trainer[] trainers;
        public Trainer[] GetAllTrainersFromFile(Trainer[] trainers){
            StreamReader inFile = new StreamReader("trainer.txt");
            string line = inFile.ReadLine();
            Trainer.SetCount(0);
            while (line != null){
              string[] temp = line.Split('#');
              trainers[Trainer.GetCount()] = new Trainer(int.Parse(temp[0]),temp[1],temp[2],temp[3]);
              Trainer.IncCount();
              line = inFile.ReadLine();
            }
            inFile.Close();
            return trainers;
        }
    }
}
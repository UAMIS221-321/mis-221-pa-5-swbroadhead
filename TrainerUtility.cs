using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis_221_pa_5_swbroadhead
{
    public class TrainerUtility
    {
        public void GetAllTrainersFromFile(){
            StreamReader inFile = new StreamReader("trainer.txt");
            string line = inFile.ReadLine();
            Trainer.SetCount(0);
            while (line != null){
                
            }
        }
    }
}
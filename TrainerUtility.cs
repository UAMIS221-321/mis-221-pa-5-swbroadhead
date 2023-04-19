using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis_221_pa_5_swbroadhead
{
    public class Utility
    {
        private Trainer[] trainers;

        public Utility(Trainer[] trainers){
            this.trainers = trainers;
        }
        public void GetAllTrainers(){
            StreamReader inFile = new StreamReader("trainer.txt");
            Trainer.SetCount(0);
            string line = inFile.ReadLine();
            while(line!=null){
                string[] temp = line.Split('#');
                trainers[Trainer.GetCount()] = new Trainer(temp[0],temp[1],temp[2],temp[3]);
                Trainer.IncCount();
                line = inFile.ReadLine();
            }
            inFile.Close();
        }
        public void PrintAllTrainers(){
            for (int i = 0;i < Trainer.GetCount(); i++){
                Console.WriteLine(trainers[i].ToString());
            }
        }
        public void TrainerMenu(){
            System.Console.WriteLine("Enter 1 to Add Trainers");
            System.Console.WriteLine("Enter 2 to Edit Trainers");
            System.Console.WriteLine("Enter 3 to Delete Trainers");
            string choice = Console.ReadLine();
        }
    }
}
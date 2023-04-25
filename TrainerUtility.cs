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
//constructor instantiates trainer array when called
        public TrainerUtility(){
            trainers = new Trainer[100];
        }
        public Trainer[] GetTrainers(){
            return trainers;
        }
        //scans trainer file and populates trainer array
        public Trainer[] GetAllTrainersFromFile(){
            StreamReader inFile = new StreamReader("trainer.txt");
            string line = inFile.ReadLine();
            Trainer.SetCount(0);
            while (line != null){
             if(!string.IsNullOrWhiteSpace(line)){
                Array.Resize(ref trainers, Trainer.GetCount()+1);
              string[] temp = line.Split('#');
             trainers[Trainer.GetCount()] = new Trainer(int.Parse(temp[0]),temp[1],temp[2],temp[3]);
              Trainer.IncCount();
             }
              line = inFile.ReadLine();
            }
            inFile.Close();
            return trainers;
        }
        //adds new trainer to array
        public void AddNewTrainer(){
          System.Console.WriteLine("Follow the prompt to add a new trainer, enter STOP to stop \n Press any key to continue");
        Console.ReadKey();
        string input = "";
        while(input.ToUpper() != "STOP"){
        int trainerCount = Trainer.GetCount();
          trainers[trainerCount] = new Trainer(trainerCount+1,"","","");
          System.Console.WriteLine("Please enter Trainer Name");
         input = Console.ReadLine();
         if (input.ToUpper() == "STOP"){
            break;
         }
          trainers[trainerCount].SetName(input);
          System.Console.WriteLine("Please enter trainer email");
          input = Console.ReadLine();
           if (input.ToUpper() == "STOP"){
            break;
         }
          trainers[trainerCount].SetEmail(input);
          System.Console.WriteLine("Please enter trainer mailing address");
          input = Console.ReadLine();
          trainers[trainerCount].SetAddress(input);
             if (input.ToUpper() == "STOP"){
            break;
         }
          Trainer.IncCount();
        }
        }
        //writes trainer array to file
        public void WriteTrainersToFile(){
            StreamWriter outFile = new StreamWriter("trainer.txt");
            for (int i = 0; i < Trainer.GetCount(); i++){
                int fileID = trainers[i].GetID();
                string fileTrainer = trainers[i].GetName();
                string fileEmail = trainers[i].GetEmail();
                string fileAddress = trainers[i].GetAddress();
                outFile.WriteLine($"{fileID}#{fileTrainer}#{fileEmail}#{fileAddress}");
            }
            outFile.Close();
        }
        //edits trainer based on user input
    public void EditTrainers(){
       System.Console.WriteLine("Enter the trainer ID that you want to edit");
       int editID = int.Parse(Console.ReadLine());
       Trainer editTrainer =  null;
       for (int i = 0; i < Trainer.GetCount(); i++){
        if (trainers[i].GetID() == editID){
            editTrainer = trainers[i];


            break;
        }
       }
        if (editTrainer == null){
            System.Console.WriteLine("Trainer ID not found");
            return;
        }
        System.Console.WriteLine($"Editing Trainer {editTrainer.GetName()} ID: {editTrainer.GetID()}");
        System.Console.WriteLine("Would you like to change the trainer's name? Enter new name if so or leave blank to leave it the same");
        string newName = Console.ReadLine();
        if (!string.IsNullOrEmpty(newName)){
            editTrainer.SetName(newName);
        }
        System.Console.WriteLine("Change trainer email? enter new email if so or leave blank to remain unchanged");
        string nuEmail = Console.ReadLine();
        if (!string.IsNullOrEmpty(newName)){
            editTrainer.SetEmail(nuEmail);
        }
        System.Console.WriteLine("Change mailing address? enter new address if so or leave blank to remain unchanged");
        string nuAddress = Console.ReadLine();
        if (!string.IsNullOrEmpty(nuAddress)){
            editTrainer.SetAddress(nuAddress);
        }
        System.Console.WriteLine("Trainer Information Updated");
    }
    //removes trainer and decreases count for ID 
    public void RemoveTrainer(){
        System.Console.WriteLine("Enter the trainer id which you want to remove");
        int removeID = int.Parse(Console.ReadLine());
        bool found = false;
        for (int i = 0; i< Trainer.GetCount();i++){
            if (trainers[i].GetID() == removeID){
                found = true;
                for (int x = 0; x < Trainer.GetCount()-1; x++){
                    trainers[x] = trainers[x+1];
                }
                Trainer.DecCount();
                break;
            }
        }
        if (found){
            WriteTrainersToFile();
            System.Console.WriteLine($"Trainer ID {removeID} has been removed");
        }
        else{
            System.Console.WriteLine("ID not found");
        }
    }

    //trainer menu
    public void TrainerMenu(TrainerUtility util)
{
    System.Console.WriteLine("Welcome to the trainer menu");
    System.Console.WriteLine("Enter 1 to Add Trainers");
    System.Console.WriteLine("Enter 2 to Edit Trainers");
    System.Console.WriteLine("Enter 3 to Delete Trainers");
    System.Console.WriteLine("Enter 4 to return to main menu");
     string userChoice = Console.ReadLine();
     if (userChoice == "1"){
        util.AddNewTrainer();
     }
     else if (userChoice == "2"){
        util.EditTrainers();
     }
     else if (userChoice == "3"){
        util.RemoveTrainer();
     }
     else if (userChoice == "4"){
        System.Console.WriteLine("exiting...");
     }
      }

    }

}
//Start Main
using mis_221_pa_5_swbroadhead;
using Utility;
TrainerUtility util = new TrainerUtility();
util.GetAllTrainersFromFile();
for (int i =0; i < Trainer.GetCount();i++){
    System.Console.WriteLine($"Trainer {i+1}: ID = {util.trainers[i].GetID()}");
}
util.EditTrainers();



// string userChoice = GetUserChoice();
// //End Main

// static string GetUserChoice(){
//     DisplayMenu();
//     string userInput = Console.ReadLine();
//     while(!IsValidChoice(userInput)){
//         System.Console.WriteLine("Invalid Input! Press any key to continue");
//         Console.ReadKey();
//         DisplayMenu();
//         userInput = Console.ReadLine();
//     }
//     return userInput;
// }

// static void DisplayMenu(){
//     System.Console.WriteLine("Welcome to Train Like A Champion! Please make your selection");
//     System.Console.WriteLine("Enter 1 to Manage Trainer Data");
//     System.Console.WriteLine("Enter 2 to Manage Listing Data");
//     System.Console.WriteLine("Enter 3 to Manage Customer Booking Data");
//     System.Console.WriteLine("Enter 4 to Run Reports");
//     System.Console.WriteLine("Enter 5 to Exit");
// }

// static bool IsValidChoice(string userChoice){
//     if (userChoice == "1" || userChoice == "2" || userChoice == "3" || userChoice == "4" || userChoice == "5"){
//         return true;
//     }
//     else return false;
// }

// static void Route(string userChoice)
// {
// if (userChoice == "1"){
//     TrainerMenu();
// }
// }
// static void TrainerMenu()
// {
//     System.Console.WriteLine("Enter 1 to Add Trainers");
//     System.Console.WriteLine("Enter 2 to Edit Trainers");
//     System.Console.WriteLine("Enter 3 to Delete Trainers");
//     System.Console.WriteLine("Enter 4 to return to main menu");
//      string choice = Console.ReadLine();
//      if (choice == "1"){
        
//      }
//      else if (choice == "2"){
    
//      }
//      else if (choice == "3"){

//      }
//      else if (choice == "4"){

//      }
//       }
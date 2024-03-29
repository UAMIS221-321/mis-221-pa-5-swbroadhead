﻿//Start Main
using mis_221_pa_5_swbroadhead;
using Utility;
TrainerUtility train = new TrainerUtility();
ListingUtility lists = new ListingUtility();
TransactionUtility transaction = new TransactionUtility();
Trainer[] trainers = train.GetAllTrainersFromFile();
Listing[] listings = lists.GetAllListingsFromFile();
Transaction[] transactions = transaction.GetAllTransactionsFromFile();
Report report = new Report(transactions,listings,trainers);

string userChoice = "";
while (userChoice != "5"){
    userChoice = GetUserChoice();
    Route(userChoice,train,lists,transaction);
}
//End Main

static string GetUserChoice(){
    DisplayMenu();
    string userInput = Console.ReadLine();
    while(!IsValidChoice(userInput)){
        System.Console.WriteLine("Invalid Input! Press any key to continue");
        Console.ReadKey();
        DisplayMenu();
        userInput = Console.ReadLine();
    }
    return userInput;
}

static void DisplayMenu(){
    System.Console.WriteLine("Welcome to Train Like A Champion! Please make your selection");
    System.Console.WriteLine("Enter 1 to Manage Trainer Data");
    System.Console.WriteLine("Enter 2 to Manage Listing Data");
    System.Console.WriteLine("Enter 3 to Manage Customer Booking Data");
    System.Console.WriteLine("Enter 4 to Run Reports");
    System.Console.WriteLine("Enter 5 to Exit");
}

static bool IsValidChoice(string userChoice){
    if (userChoice == "1" || userChoice == "2" || userChoice == "3" || userChoice == "4" || userChoice == "5"){
        return true;
    }
    else return false;
}
//routes based on userchoice
static void Route(string userChoice,TrainerUtility train, ListingUtility list,TransactionUtility transaction)
{
if (userChoice == "1"){
    TrainerMenu(train);
}
if (userChoice == "2"){
    ListingMenu(list);
}
if (userChoice == "3"){
    TransactionMenu(transaction);
}
//menu for trainer functions
}
 static string TrainerMenu(TrainerUtility train)
{
    System.Console.WriteLine("Welcome to the trainer menu");
    System.Console.WriteLine("Enter 1 to Add Trainers");
    System.Console.WriteLine("Enter 2 to Edit Trainers");
    System.Console.WriteLine("Enter 3 to Delete Trainers");
    System.Console.WriteLine("Enter 4 to return to main menu");
     string userChoice = Console.ReadLine();
     while(!IsValidChoice(userChoice)){
        System.Console.WriteLine("Invalid Input! Press any key to continue");
        Console.ReadKey();
        TrainerMenu(train);
     }
     if (userChoice == "1"){
        train.AddNewTrainer();
     }
     else if (userChoice == "2"){
        train.EditTrainers();
     }
     else if (userChoice == "3"){
        train.RemoveTrainer();
     }
     else if (userChoice == "4"){
        System.Console.WriteLine("exiting...");
        GetUserChoice();
     }
     return userChoice;
} 
//menu for listing functions
     static void ListingMenu(ListingUtility list){
        System.Console.WriteLine("Welcome to the listing menu");
        System.Console.WriteLine("Enter 1 to add new listing");
        System.Console.WriteLine("Enter 2 to edit listing");
        System.Console.WriteLine("Enter 3 to delete listing");
        System.Console.WriteLine("Enter 4 to exit");
        string userChoice = Console.ReadLine();
        while(!IsValidChoice(userChoice)){
            System.Console.WriteLine("Invalid input! Press any key to continue");
            Console.ReadKey();
            ListingMenu(list);
        }
        if (userChoice == "1"){
            list.AddNewListing();
        }
        if (userChoice == "2"){
            list.EditListing();

        }
        if (userChoice == "3"){
            list.RemoveListing();
        }
        if (userChoice == "4"){
            System.Console.WriteLine("exiting...");
            GetUserChoice();
        }
     }
     //menu for transaction or booking functions
static void TransactionMenu(TransactionUtility transaction){
    System.Console.WriteLine("Welcome to the transactin menu");
    System.Console.WriteLine("Enter 1 to view available sessions");
    System.Console.WriteLine("Enter 2 to add a session");
    System.Console.WriteLine("Enter 3 to edit a session");
    System.Console.WriteLine("Enter 4 to delete a session");
    System.Console.WriteLine("Enter 5 to return to the main menu");
    string userChoice = Console.ReadLine();
    if (userChoice == "1"){
        transaction.ViewAvailableSessions();
    }
    if (userChoice == "2"){
        transaction.AddNewTransaction();
    }
    if (userChoice == "3"){
        transaction.EditTransaction();
    }
    if (userChoice == "4"){
        transaction.EditTransaction();
    }
    if (userChoice == "5"){
        System.Console.WriteLine("exiting...");
        GetUserChoice();
    }

}
//menu for reporting functions
static void ReportMenu(Report report){
    System.Console.WriteLine("Welcome to the report menu");
    System.Console.WriteLine("Enter 1 to view individual customer sessions");
    System.Console.WriteLine("Enter 2 to view historical customer sessions");
    System.Console.WriteLine("Enter 3 to view historical revenue reports");
    System.Console.WriteLine("Enter 4 to exit");
    string userChoice = Console.ReadLine();
    if (userChoice == "1"){
        report.IndivCustomerSessions();
    }
    if (userChoice == "2"){
        report.HistoricalSessions();
    }
    if (userChoice == "3"){
        System.Console.WriteLine("Couldn't get to work :(");
        GetUserChoice();
    }
    if (userChoice == "4"){
        System.Console.WriteLine("exiting...");
        GetUserChoice();
    }
}
     
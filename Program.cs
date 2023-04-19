//Start Main
using mis_221_pa_5_swbroadhead;
string userChoice = GetUserChoice();
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

static void Route(string userChoice)
{
if (userChoice == "1"){
    
}
}

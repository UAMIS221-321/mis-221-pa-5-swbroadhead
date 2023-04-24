using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis_221_pa_5_swbroadhead
{
    public class ListingUtility
    {
    public Listing[] listings;
//constructor instantiates listing array when called
    public ListingUtility(){
        listings = new Listing[100];
    }
    //scans file and populates listing array, ignoring any lines that are empty
        public Listing[] GetAllListingsFromFile(){
            StreamReader inFile = new StreamReader("listings.txt");
            string line = inFile.ReadLine();
            Listing.SetCount(0);
            while (line != null){
             if(!string.IsNullOrWhiteSpace(line)){
                Array.Resize(ref listings, Listing.GetCount()+1);
              string[] temp = line.Split('#');
             listings[Listing.GetCount()] = new Listing(int.Parse(temp[0]),temp[1],DateTime.Parse(temp[2]),TimeSpan.Parse(temp[3]),double.Parse(temp[4]),bool.Parse(temp[5]));
              Listing.IncCount();
             }
              line = inFile.ReadLine();
            }
            inFile.Close();
            return listings;
        }
        //adds new listing to listing array
        public void AddNewListing(){
          System.Console.WriteLine("Follow the prompt to add a new listing, enter STOP to stop \n Press any key to continue");
        Console.ReadKey();
        string input = "";
        while(input.ToUpper() != "STOP"){
        int listingCount = Listing.GetCount();
        Array.Resize(ref listings,listingCount+1);
          System.Console.WriteLine("Please enter Trainer Name");
         input = Console.ReadLine();
         if (input.ToUpper() == "STOP"){
            break;
         }
         string trainerName = input;
        System.Console.WriteLine("Please enter the date of the session");
          input = Console.ReadLine();
           if (input.ToUpper() == "STOP"){
            break;
         }
         DateTime sessionDate = DateTime.Parse(input);;
          System.Console.WriteLine("Please enter the time of the session");
          input = Console.ReadLine();
             if (input.ToUpper() == "STOP"){
            break;
         }
         TimeSpan sessionTime = TimeSpan.Parse(input);
          System.Console.WriteLine("Please enter the cost of the session");
          input = Console.ReadLine();
          if(input.ToUpper() == "STOP"){
            break;
          }
          double sessionCost = double.Parse(input);
          System.Console.WriteLine("Is the listing taken? yes/no");
          input = Console.ReadLine();
          if (input.ToUpper() == "STOP"){
            break;
          }
          bool isTaken = input.ToLower() == "yes";
          listings[listingCount] = new Listing(listingCount +1,trainerName,sessionDate,sessionTime,sessionCost,isTaken);
          Listing.IncCount();
        }
        }
        //writes listing array to file
                public void WriteListingsToFile(){
            StreamWriter outFile = new StreamWriter("listings.txt");
            for (int i = 0; i < Listing.GetCount(); i++){
                int fileID = listings[i].GetID();
                string fileTrainer = listings[i].GetTrainerName();
                string fileDate = listings[i].GetSessionDate().ToString("mm/dd/yyyy");
                TimeSpan fileTime = listings[i].GetSessionTime();
                double fileCost = listings[i].GetSessionCost();
                bool fileIsTaken = listings[i].GetAvailability();
                outFile.WriteLine($"{fileID}#{fileTrainer}#{fileDate}#{fileTime}#{fileCost}#{fileIsTaken}");
                
            }
            outFile.Close();
        }
        //prompts user and changes listing based on input
            public void EditListing(){
       System.Console.WriteLine("Enter the Listing ID that you want to edit");
       int editID = int.Parse(Console.ReadLine());
       Listing editListing =  null;
       for (int i = 0; i < Listing.GetCount(); i++){
        if (listings[i].GetID() == editID){
            editListing = listings[i];


            break;
        }
       }
        if (editListing == null){
            System.Console.WriteLine("Listing ID not found");
            return;
        }
        System.Console.WriteLine($"Editing Listing {editListing.GetID()}");
        System.Console.WriteLine("Would you like to change the trainer's name? Enter new name if so or leave blank to leave it the same");
        string newName = Console.ReadLine();
        if (!string.IsNullOrEmpty(newName)){
            editListing.SetTrainerName(newName);
        }
        System.Console.WriteLine("Change the listing date? enter new date if so or leave blank to remain unchanged");
        string nuDate = Console.ReadLine();
        if (!string.IsNullOrEmpty(newName)){
            editListing.SetSessionDate(DateTime.Parse(nuDate));
        }
        System.Console.WriteLine("Change listing time? enter new time if so or leave blank to remain unchanged");
        string nuTime = Console.ReadLine();
        if (!string.IsNullOrEmpty(nuTime)){
            editListing.SetSessionTime(TimeSpan.Parse(nuTime));
        }
        System.Console.WriteLine("Change listing cost? enter new cost if so or leave blank to remain unchanged");
        string newCost = Console.ReadLine();
        if (!string.IsNullOrEmpty(newCost)){
          editListing.SetSessionCost(double.Parse(newCost));
        }
        System.Console.WriteLine("Change listing availability? enter true if available or false if not; leave blank to remain unchanged");
        string isTaken = Console.ReadLine();
        if (!string.IsNullOrEmpty(isTaken)){
          editListing.SetAvailability(bool.Parse(isTaken));
        }
        System.Console.WriteLine("Listing Information Updated");
    }
    //removes listing, decreases listing count so IDs stay consistent 
    public void RemoveListing(){
        System.Console.WriteLine("Enter the listing id which you want to remove");
        int removeID = int.Parse(Console.ReadLine());
        bool found = false;
        for (int i = 0; i< Listing.GetCount();i++){
            if (listings[i].GetID() == removeID){
                found = true;
                for (int x = 0; x < Listing.GetCount()-1; x++){
                    listings[x] = listings[x+1];
                }
                Listing.DecCount();
                break;
            }
        }
        if (found){
            WriteListingsToFile();
            System.Console.WriteLine($"Listing ID {removeID} has been removed");
        }
        else{
            System.Console.WriteLine("ID not found");
        }
    }
    public void ListingMenu(){
        System.Console.WriteLine("Welcome to the listing menu");
        System.Console.WriteLine("Enter 1 to Add New Listing");
        System.Console.WriteLine("Enter 2 to Edit Listings");
        System.Console.WriteLine("Enter 3 to Remove Listings");
        System.Console.WriteLine("Enter 4 to exit");
        string userChoice = Console.ReadLine();
        if (userChoice == "1"){
            AddNewListing();
        }
        if (userChoice == "2"){
            EditListing();
        }
        if (userChoice == "3"){
            RemoveListing();
        }
        if (userChoice == "4"){
            System.Console.WriteLine("exiting...");
        }


    }
    }
}
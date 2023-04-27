using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis_221_pa_5_swbroadhead
{
    public class TransactionUtility
    {
    public Transaction[] transactions;
        public Transaction[] GetAllTransactionsFromFile(){
            StreamReader inFile = new StreamReader("transactions.txt");
            string line = inFile.ReadLine();
            Transaction.SetCount(0);
            while (line != null){
             if(!string.IsNullOrWhiteSpace(line)){
                Array.Resize(ref transactions, Transaction.GetCount()+1);
              string[] temp = line.Split('#');
             transactions[Transaction.GetCount()] = new Transaction(int.Parse(temp[0]),temp[1],temp[2],DateTime.Parse(temp[3]),temp[4],int.Parse(temp[5]),bool.Parse(temp[6]));
              Transaction.IncCount();
             }
              line = inFile.ReadLine();
            }
            inFile.Close();
            return transactions;
        }
        public void AddNewTransaction(){
          System.Console.WriteLine("Follow the prompt to add a new transaction, enter STOP to stop \n Press any key to continue");
        Console.ReadKey();
        string input = "";
        while(input.ToUpper() != "STOP"){
        int transactionCount = Transaction.GetCount();
        Array.Resize(ref transactions,transactionCount+1);
          System.Console.WriteLine("Please enter customer Name");
         input = Console.ReadLine();
         if (input.ToUpper() == "STOP"){
            break;
         }
         string customerName = input;
        System.Console.WriteLine("Please enter the customer's email");
          input = Console.ReadLine();
           if (input.ToUpper() == "STOP"){
            break;
         }
        string customerEmail = input;
          System.Console.WriteLine("Please enter the date (mm/dd/yyyy) and time (12:00 AM) of the session");
          input = Console.ReadLine();
             if (input.ToUpper() == "STOP"){
            break;
         }
         DateTime sessionDate = DateTime.Parse(input);
          System.Console.WriteLine("enter trainer name");
          input = Console.ReadLine();
          string trainerName = input;
          if (input.ToUpper() == "STOP"){
            break;
          }
          System.Console.WriteLine("Enter trainer ID");
          input = Console.ReadLine();
          if (input.ToUpper() == "STOP"){
            break;
          }
          int trainerID = int.Parse(input);
          transactions[transactionCount] = new Transaction(transactionCount+1,customerName,customerEmail,sessionDate,trainerName,trainerID,false);
          Transaction.IncCount();
        }
        }
 public void WriteTransactionsToFile(){
  StreamWriter outFile = new StreamWriter("transactions.txt");
  for (int i = 0; i < Transaction.GetCount(); i++){
  int fileID = transactions[i].GetID();
  string fileCustomerName = transactions[i].GetCustomerName();
  string fileCustomerEmail = transactions[i].GetCustomerEmail();
  DateTime fileDate = transactions[i].GetTrainingDate();
  string fileTrainer = transactions[i].GetTrainerName();
  int trainerID = transactions[i].GetTrainerID();
  bool status = transactions[i].GetAvailability();
  outFile.WriteLine($"{fileID}#{fileCustomerName}#{fileCustomerEmail}#{fileDate}#{fileTrainer}#{trainerID}#{status}");
                
  }
  outFile.Close();
 } 
    public void EditTransaction(){
       System.Console.WriteLine("Enter the transaction ID that you want to edit");
       int editID = int.Parse(Console.ReadLine());
       Transaction editTransaction =  null;
       for (int i = 0; i < Transaction.GetCount(); i++){
        if (transactions[i].GetID() == editID){
            editTransaction = transactions[i];


            break;
        }
       }
        if (editTransaction == null){
            System.Console.WriteLine("Transaction not found");
            return;
        }
        System.Console.WriteLine($"Editing Transaction {editTransaction.GetID()}");
        System.Console.WriteLine("Would you like to change the customer's name? Enter new name if so or leave blank to leave it the same");
        string newName = Console.ReadLine();
        if (!string.IsNullOrEmpty(newName)){
            editTransaction.SetCustomerName(newName);
        }
        System.Console.WriteLine("Change customer email? enter new email if so or leave blank to remain unchanged");
        string nuEmail = Console.ReadLine();
        if (!string.IsNullOrEmpty(nuEmail)){
            editTransaction.SetCustomerEmail(nuEmail);
        }
        System.Console.WriteLine("Change session date? enter new date (mm/dd/yyyy) and time (12:00 AM) if so or leave blank to remain unchanged");
        string nuDate = Console.ReadLine();
        if (!string.IsNullOrEmpty(nuDate)){
            editTransaction.SetTrainingDate(DateTime.Parse(nuDate));
        }
        System.Console.WriteLine("Change trainer name? enter new name if so or leave blank to remain unchanged");
        string nuTrainerName = Console.ReadLine();
        if (!string.IsNullOrEmpty(nuTrainerName)){
          editTransaction.SetTrainerName(nuTrainerName);
        }
        System.Console.WriteLine("Change trainer ID? enter new id if so or leave blank to remain unchanged");
        string nuTrainerID = Console.ReadLine();
        if (!string.IsNullOrEmpty(nuTrainerID)){
          editTransaction.SetTrainerID(int.Parse(nuTrainerID));
        }
        System.Console.WriteLine("Change availability? enter yes if available, no if not or leave blank to remain unchanged ");
        string nuAvailability = Console.ReadLine();
        if (!string.IsNullOrEmpty(nuAvailability)){
          if (nuAvailability.ToLower() == "yes"){
            bool available = true;
            editTransaction.SetAvailability(available);
          }
          else if (nuAvailability.ToLower() == "no"){
           bool available = false;
            editTransaction.SetAvailability(available);
          }
        }
        System.Console.WriteLine("Transaction Information Updated");
    } 
public void ViewAvailableSessions(){
  System.Console.WriteLine("Available Sessions");
  for (int i = 0; i < Transaction.GetCount();i++){
    if (transactions[i].GetAvailability() == true){
      System.Console.WriteLine(transactions[i].ToString());
    }
  }
}    
}
}
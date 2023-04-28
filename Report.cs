using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis_221_pa_5_swbroadhead
{
    public class Report
    {
        private Transaction[] transactions;
        private Listing[] listings;
        private Trainer[] trainers;
public Report (Transaction[]transactions,Listing[] listings, Trainer[] trainers){
    this.transactions = transactions;
    this.trainers = trainers;
    this.listings = listings;
}
public void IndivCustomerSessions(){
    System.Console.WriteLine("Enter the customer email that you want to find");
    string email = Console.ReadLine();
    bool found = false;
    for (int i = 0; i < Transaction.GetCount(); i++){
        if (transactions[i].GetCustomerEmail() == email){
            if (!found){
                System.Console.WriteLine("Customer Sessions:");
                found = true;
            }
           System.Console.WriteLine($"Transaction ID: {transactions[i].GetID()}");
           System.Console.WriteLine($"Customer Name: {transactions[i].GetCustomerName()}");
           System.Console.WriteLine($"Session Date: {transactions[i].GetTrainingDate()}");
           System.Console.WriteLine($"Trainer Name: {transactions[i].GetTrainerName()}");
           System.Console.WriteLine($"Trainer ID: {transactions[i].GetTrainerID()}");
           System.Console.WriteLine("Would you like to save the report to a file?");
           string choice = Console.ReadLine();
           if (choice.ToLower() == "yes"){
           }
        }
    }
    if (!found){
        System.Console.WriteLine("No sessions found :(");
    }
}
public void HistoricalSessions(){
Transaction[] customerSessions = new Transaction[Transaction.GetCount()];
int count = 0;
for (int i = 0; i < transactions.Length; i++){
    if (transactions[i] != null){
        customerSessions[count++] = transactions[i];
    }
}
//bubble sort based on customer name and session date
for (int i = 0; i < count -1; i++){
    for (int j = 0; j < count - 1 - i; j++){
      int result = customerSessions[j].GetCustomerName().CompareTo(customerSessions[j + 1].GetCustomerName());
      if (result > 0 || (result == 0 && customerSessions[j].GetTrainingDate() > customerSessions[j+1].GetTrainingDate())){
        Transaction temp = customerSessions[j];
        customerSessions[j] = customerSessions[j+1];
        customerSessions[j+1] = temp;
      }  
    }
}
System.Console.WriteLine("Historical Customer Sessions");
string currCustomer = "";
int sessionCount = 0;
//list of customers and session info
for (int i = 0; i < count; i++){
    if (customerSessions[i].GetCustomerName() != currCustomer){
        if (i != 0){
            System.Console.WriteLine($"Total sessions for Customer {currCustomer}: {sessionCount}");
        }
        currCustomer = customerSessions[i].GetCustomerName();
        sessionCount = 0;
    }
    System.Console.WriteLine($"Customer: {customerSessions[i].GetCustomerName()} Email: {customerSessions[i].GetCustomerEmail()}");
    System.Console.WriteLine($"Session Date: {customerSessions[i].GetTrainingDate()}");
    System.Console.WriteLine($"Trainer: {customerSessions[i].GetTrainerName()}");
    sessionCount++;
}
System.Console.WriteLine($"Total sessions for {currCustomer}: {sessionCount}");
}

//doesn't work, couldn't for the life of me figure out why
// public void HistoricalRevReport(){
//     double[] monthlyRev = new double [12];
//     int currentYear = DateTime.Now.Year;
//     int baseYear = 2000;
//     int[] yearlyRev = new int [currentYear - baseYear +1];
//     //revenue calculation
//     for (int i = 0; i < listings.Length; i++){
//         if (listings[i]!= null){
//             int month = listings[i].GetSessionDate().Month;
//             int year = listings[i].GetSessionDate().Year - baseYear;
//             double cost = listings[i].GetSessionCost();
//             monthlyRev[month - 1] += cost;
//             yearlyRev[year] += (int)cost;
//         }
//     }
//     //bubble sort and swap based on year
//    for (int i = 0; i < yearlyRev.Length; i++){
//     for (int j = 0; j < yearlyRev.Length - 1 - i; j++){
//         if (yearlyRev[j] < yearlyRev[j+1]){
//             int temp = yearlyRev[j];
//             yearlyRev[j] = yearlyRev[j +1];
//             yearlyRev[j+1] = temp;
//         }
//     }

//    } 
//     System.Console.WriteLine("Yearly Revenue Report");
//    System.Console.WriteLine("Revenue by month");
//    for (int i = 0; i < 12; i++){
//     System.Console.WriteLine($"Month {i + 1}: {monthlyRev[i]}");
//    }   
//    System.Console.WriteLine("Revenue by year");
//    for (int i = 0; i < yearlyRev.Length; i++){
//     System.Console.WriteLine($"Year: {i + 2000}: {yearlyRev[i]}");
//    }
// }


   }
}
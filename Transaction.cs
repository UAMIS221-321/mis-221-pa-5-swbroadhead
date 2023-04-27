using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static mis_221_pa_5_swbroadhead.Trainer;

namespace mis_221_pa_5_swbroadhead
{
    public class Transaction
    {
        private int transactionID;
        private string customerName;
        private string customerEmail;
        private DateTime trainingDate;
        private int trainerID;
        private string trainerName;
        private bool available;
        static private int count;
    public Transaction(int transactionID,string customerName, string customerEmail, DateTime trainingDate, string trainerName, int trainerID, bool available){
        this.transactionID = transactionID;
        this.customerName = customerName;
        this.customerEmail = customerEmail;
        this.trainingDate = trainingDate;
        this.available = available;
        this.trainerID = trainerID;
        this.trainerName = trainerName;
    }
    public int GetID(){
        return transactionID;
    }
    public string GetCustomerName(){
        return customerName;
    }
    public string GetCustomerEmail(){
        return customerEmail;
    }
    public DateTime GetTrainingDate(){
        return trainingDate;
    }
    public bool GetAvailability(){
        return available;
    }
    public static int GetCount(){
        return count;
    }
    public void SetTransactionID(int transactionID){
        this.transactionID = transactionID;
    }
    public void SetCustomerName(string customerName){
        this.customerName = customerName;
    }
    public void SetCustomerEmail(string customerEmail){
        this.customerEmail = customerEmail;
    }
    public void SetTrainingDate(DateTime trainingDate){
        this.trainingDate = trainingDate;
    }
    public void SetAvailability(bool available){
        this.available = available;
    }
    public static void SetCount(int count){
        Transaction.count = count;
    }
    public static void IncCount(){
        Transaction.count++;
    }
    public static void DecCount(){
        Transaction.count--;
    }
    public string GetTrainerName(){
        return trainerName;
    }
    public void SetTrainerName(string trainerName){
        this.trainerName = trainerName;
    }
    public int GetTrainerID(){
        return trainerID;
    }
    public void SetTrainerID(int trainerID){
        this.trainerID = trainerID;
    }
    }
}
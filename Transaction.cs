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
    public Transaction(int transactionID,string customerName, string customerEmail, DateTime trainingDate, Trainer trainer, bool available){
        this.transactionID = transactionID;
        this.customerName = customerName;
        this.customerEmail = customerEmail;
        this.trainingDate = trainingDate;
        this.available = available;
        this.trainerID = trainer.GetID();
        this.trainerName = trainer.GetName();
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
    public void SetTransactionID(int id){
        this.transactionID = transactionID;
    }
    public void SetCustomerName(string name){
        this.customerName = customerName;
    }
    public void SetCustomerEmail(string email){
        this.customerEmail = customerEmail;
    }
    public void SetTrainingDate(DateTime date){
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
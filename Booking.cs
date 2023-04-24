using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis_221_pa_5_swbroadhead
{
    public class Booking
    {
        private int transactionID;
        private string customerName;
        private string customerEmail;
        private DateTime trainingDate;
        private int trainerID;
        private string trainerName;
        private bool available;
    public Booking(int transactionID,string customerName, string customerEmail, DateTime trainingDate, int trainerID, string trainerName, bool available){
        this.transactionID = transactionID;
        this.customerName = customerName;
        this.customerEmail = customerEmail;
        this.trainingDate = trainingDate;
        this.trainerID = trainerID;
        this.trainerName = trainerName;
        this.available = available;
    }
    }
}
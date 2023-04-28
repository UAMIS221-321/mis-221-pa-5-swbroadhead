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

        public Report(Transaction[]transactions,Listing[]listings,Trainer[]trainers){
            this.transactions = transactions;
            this.listings = listings;
            this.trainers = trainers;
        }
        public void RevenueReport(){
            int[] year = new int[0];
            double[] profits = new double[0];
            for (int i =0; i< Transaction.GetCount();i++){
           // DateTime seshDate = transactions.
            }
        }
    }
}
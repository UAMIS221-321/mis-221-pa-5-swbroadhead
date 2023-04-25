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
              Trainer trainer = FindTrainerByName()
             transactions[Transaction.GetCount()] = new Transaction(int.Parse(temp[0]),temp[1],temp[2],DateTime.Parse(temp[3]),);
              Transaction.IncCount();
             }
              line = inFile.ReadLine();
            }
            inFile.Close();
            return transactions;
        }
public Trainer FindTrainerByName(string name, Trainer[]trainers){
  for (int i =0; i < Trainer.GetCount();i++){
    if (trainers[i].GetName() == name){
      return trainers[i];
    }
  }
  return null;
}
public Trainer FindTrainerByID(int trainerID, Trainer[]trainers){
  for (int i = 0; i < Trainer.GetCount();i++){
    if (trainers[i].GetID() == trainerID){
      return trainers[i];
    }
  }
  return null;
}
}
}
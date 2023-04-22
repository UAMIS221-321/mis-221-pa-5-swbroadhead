using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis_221_pa_5_swbroadhead
{
    public class Trainer
    {
         private int id;
         private string name;
         private string email;
        private string address;
        static private int trainerCount;
        public Trainer(int id, string name, string email, string address){
            this.id = id;
            this.name = name;
            this.email = email;
            this.address = address;
        }
        public int GetID(){
            return id;
        }
        public void SetID(int id){
            this.id = id;
        }
         public void IncID(){
            id++;
        }
        public string GetName(){
            return name;
        }
        public void SetName(string name){
            this.name = name;
        }

        public string GetEmail(){
            return email;
        }
        public void SetEmail(string email){
            this.email = email;
        }
        public string GetAddress(){
            return address;
        }
        public void SetAddress(string address){
            this.address = address;
        }
        static public int GetCount(){
            return Trainer.trainerCount;
        }
        static public void SetCount(int count){
            Trainer.trainerCount = count;
        }
        static public void IncCount(){
            Trainer.trainerCount++;
        }
        static public void DecCount(){
            Trainer.trainerCount--;
        }
        public override string ToString()
        {
            return$"{id}#{name}#{email}#{address}";
        }
        public string ToFile(){
            return$"{GetID()}#{GetName()}#{GetEmail()}#{GetAddress()}";
        }
    }
}
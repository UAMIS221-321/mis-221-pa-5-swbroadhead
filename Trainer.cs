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
         static private int count;
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
            return Trainer.count;
        }
        static public void SetCount(int count){
            Trainer.count = count;
        }
        static public void IncCount(){
            Trainer.count++;
        }
        public override string ToString()
        {
            return$"{id}#{name}#{email}#{address}";
        }
    }
}
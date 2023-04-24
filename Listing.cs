using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis_221_pa_5_swbroadhead
{
    public class Listing
    {
  private int ID;
private string trainerName;
private DateTime sessionDate;

private TimeSpan sessionTime;

private double sessionCost;

private bool isTaken;

static private int listingCount;

public Listing(int id, string trainerName, DateTime sessionDate, TimeSpan sessionTime, double sessionCost, bool isTaken){
    this.ID = id;
    this.trainerName = trainerName;
    this.sessionDate = sessionDate;
    this.sessionTime = sessionTime;
    this.sessionCost = sessionCost;
    this.isTaken = isTaken;

} 
  public int GetID(){
    return ID;
  }
  public string GetTrainerName(){
    return trainerName;
  }
  public DateTime GetSessionDate(){
    return sessionDate;
  }
  public TimeSpan GetSessionTime(){
    return sessionTime;
  }
  public double GetSessionCost(){
    return sessionCost;
  }
  public bool GetAvailability(){
    return isTaken;
  }
   static public int GetCount(){
    return Listing.listingCount;
  }
  static public void SetCount(int count){
    Listing.listingCount = count;
  }
  static public void IncCount(){
    Listing.listingCount++;
  }
  static public void DecCount(){
    Listing.listingCount--;
  }
  public void SetID(int ID){
    this.ID = ID;
  }
  public void SetTrainerName(string trainerName){
    this.trainerName = trainerName;
  }
  public void SetSessionDate(DateTime sessionDate){
    this.sessionDate = sessionDate;
  }
  public void SetSessionTime(TimeSpan sessionTime){
    this.sessionTime = sessionTime;
  }
  public void SetSessionCost(double sessionCost){
    this.sessionCost = sessionCost;
  }
  public void SetAvailability(bool isTaken){
    this.isTaken = isTaken;
  }
        public override string ToString()
        {
            return $"{ID}${trainerName}#{sessionDate}#{sessionTime}#{sessionCost}#{isTaken}";
        }


    }
}
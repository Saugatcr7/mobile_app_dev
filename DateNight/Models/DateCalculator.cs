namespace DateNight.Models;

public class DateCalculator
{
    public string CoffeeCost{get;set;}
    public string DinnerCost{get;set;}
    public string MoiveCost{get;set;}

    public string GetTotalCost()
    {
       double dblCoffee,dblDinner,dblMoive;
       if (!double.TryParse(CoffeeCost, out dblCoffee))
       {
           if (!string.IsNullOrEmpty(CoffeeCost))
           {
               throw new Exception("Coffee cost not valid");
           }
           
       }
       if (!double.TryParse(DinnerCost, out dblDinner))
       {
           if (!string.IsNullOrEmpty(DinnerCost))
           {
               throw new Exception("Dinner cost not valid");
           }
           
       }
       if (!double.TryParse(MoiveCost, out dblMoive))
       {
           if (!string.IsNullOrEmpty(MoiveCost))
           {
               throw new Exception("Movie cost not valid");
           }
           
       }
       return (dblCoffee + dblDinner + dblMoive).ToString("C");
       
    }
}
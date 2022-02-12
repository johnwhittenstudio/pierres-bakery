using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadQuantity { get; set; }
    public int BreadCost { get; set; }
    public Bread(int breadQuantity, int breadCost = 0)
    {
      BreadQuantity = breadQuantity;
      BreadCost = breadCost;
    }
    //Buy 2, get 1 free (every 3rd loaf of bread is free.). A single loaf costs $5, two loaves costs $10, and three loaves cost $10.
    public int SetPrice()
    {
      if((BreadQuantity % 3) == 0)
      {
        BreadCost = (BreadQuantity / 3) * 10;
      }
      else if ((BreadQuantity % 3) != 0);
      {
        BreadCost = ((BreadQuantity / 3) * 10) + ((BreadQuantity % 3) * 5);
        return BreadCost;
      }  
    }
  }


  public class Pastry
  {
    public int PastryQuantity { get; set; }
    public int PastryCost { get; set; }
    public Pastry(int pastryQuantity, int pastryCost = 0)
    {
      PastryQuantity = pastryQuantity;
      PastryCost = pastryCost;
    }
    //Buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10.
    public int SetPrice()
    {
      if((PastryQuantity % 3) == 0)
      {
        PastryCost = (PastryQuantity / 3) * 5;
      }
      else if ((PastryQuantity % 3) != 0);
      {
        PastryCost = ((PastryQuantity / 3) * 5) + ((PastryQuantity % 3) * 2);
        return PastryCost;
      }  
    }
  }


  public class OrderTotal
  {
    public static int CalculateOrder(int BreadCost, int PastryCost)
    {
      int Total = BreadCost + PastryCost;
      return Total;
    }
  }


}
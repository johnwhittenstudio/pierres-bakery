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
  }
}
using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery.Models 
{

  public class PierresBakery
  {
    public static void Main()
    {

      Console.WriteLine("---------------------~---------------------");
      Console.WriteLine("~•~~•~•~~•~•~~•~•~~/~/~/~•~~•~•~~•~•~~•~•~~");
      Console.WriteLine("~•~•~                                 ~•~•~");
      Console.WriteLine("~•~      Welcome to Pierre's Bakery     ~•~");
      Console.WriteLine("~•~•~                                 ~•~•~");
      Console.WriteLine("~•~~•~•~~•~•~~•~•~~/~/~/~•~~•~•~~•~•~~•~•~~");
      Console.WriteLine("---~------~----------~----------~------~---");
      Console.WriteLine("~•~~•~•~~•~•~~•~•~~/~/~/~•~~•~•~~•~•~~•~•~~");
      Console.WriteLine("-~-                                     -~-");
      Console.WriteLine("-~-             -~•~•~•~•~-             -~-");
      Console.WriteLine("-~-  Daily deals on Bread and Pastries  -~-");
      Console.WriteLine("-~-             -~•~•~•~•~-             -~-");
      Console.WriteLine("-~-                                     -~-");
      Console.WriteLine("-~-    Bread is $5, Buy 2 get 1 free    -~-");
      Console.WriteLine("-~-       ~•~   ~•~     ~•~   ~•~       -~-");
      Console.WriteLine("-~- Pastries are $2, Buy 2 get 1 for $1 -~-"); 
      Console.WriteLine("-~-                                     -~-");
      Console.WriteLine("-~-             -~•~•~•~•~-             -~-");
      Console.WriteLine("                                           ");
      Console.WriteLine(" What would you like? type Bread or Pastry ");
      Console.WriteLine("                                           ");
      Console.WriteLine("-~-             -~•~•~•~•~-             -~-");
      Console.WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
      string userOrder = Console.ReadLine().ToLower();

      if (userOrder == "bread")
      {
        Console.WriteLine("---~------~----------~----------~------~---");
        Console.WriteLine("~•~~•~•~~•~•~~•~•~~/~/~/~•~~•~•~~•~•~~•~•~~");
        Console.WriteLine("-~-             -~•~•~•~•~-             -~-");    
        Console.WriteLine("~•~           How many loaves?          ~•~");
        Console.WriteLine("-~-             -~•~•~•~•~-             -~-");    
        Console.WriteLine("~•~~•~•~~•~•~~•~•~~/~/~/~•~~•~•~~•~•~~•~•~~");
        Console.WriteLine("---~------~----------~----------~------~---");
        string breadQuantity = Console.ReadLine();
        int parsBreadQuantity = int.Parse(breadQuantity);
        Bread newBread = new Bread(parsBreadQuantity);
        int breadCost = newBread.SetPrice();
        Console.WriteLine("---~------~----------~----------~------~---");
        Console.WriteLine("~•~~•~•~~•~•~~•~•~~/~/~/~•~~•~•~~•~•~~•~•~~");
        Console.WriteLine("-~-             -~•~•~•~•~-             -~-");    
        Console.WriteLine("~•~    Any pastries?  type Yes or No    ~•~");
        Console.WriteLine("-~-             -~•~•~•~•~-             -~-");    
        Console.WriteLine("~•~~•~•~~•~•~~•~•~~/~/~/~•~~•~•~~•~•~~•~•~~");
        Console.WriteLine("---~------~----------~----------~------~---");
        
        string continueOrder = Console.ReadLine().ToLower(); 
        if (continueOrder == "no");
        {
          Console.WriteLine("---~------~----------~----------~------~---");
          Console.WriteLine("~•~~•~•~~•~•~~•~•~~/~/~/~•~~•~•~~•~•~~•~•~~");
          Console.WriteLine("-~-             -~•~•~•~•~-             -~-");    
          Console.WriteLine("~•~       " + parsBreadQuantity + " loaves comes to $" + breadCost + ".       ~•~");
          Console.WriteLine("-~-       ~•~   ~•~     ~•~   ~•~       -~-");
          Console.WriteLine("~•~    Thank you!!  Have a nice day.    ~•~");
          Console.WriteLine("-~-             -~•~•~•~•~-             -~-");    
          Console.WriteLine("~•~~•~•~~•~•~~•~•~~/~/~/~•~~•~•~~•~•~~•~•~~");
          Console.WriteLine("---~------~----------~----------~------~---");
        } if (continueOrder == "yes") 
        {
          Console.WriteLine("---~------~----------~----------~------~---");
          Console.WriteLine("~•~~•~•~~•~•~~•~•~~/~/~/~•~~•~•~~•~•~~•~•~~");
          Console.WriteLine("-~-             -~•~•~•~•~-             -~-");    
          Console.WriteLine("~•~         How many pastries?          ~•~");
          Console.WriteLine("-~-             -~•~•~•~•~-             -~-");    
          Console.WriteLine("~•~~•~•~~•~•~~•~•~~/~/~/~•~~•~•~~•~•~~•~•~~");
          Console.WriteLine("---~------~----------~----------~------~---");
          string pastryQuantity = Console.ReadLine();
          int parsPastryQuantity = int.Parse(pastryQuantity);
          Pastry newPastry = new Pastry(parsPastryQuantity);
          int pastryCost = newPastry.SetPrice();
          int orderTotal = OrderTotal.CalculateOrder(breadCost, pastryCost);
          Console.WriteLine("---~------~----------~----------~------~---");
          Console.WriteLine("~•~~•~•~~•~•~~•~•~~/~/~/~•~~•~•~~•~•~~•~•~~");
          Console.WriteLine("-~-             -~•~•~•~•~-             -~-");    
          Console.WriteLine("~•~       " + parsBreadQuantity + " loaves comes to $" + breadCost + ".       ~•~");
          Console.WriteLine("~•~      " + parsPastryQuantity + " pastries comes to $" + pastryCost + ".      ~•~");
          Console.WriteLine("-~-             -~•~•~•~•~-             -~-");              
          Console.WriteLine("~•~       Your total comes to $" + orderTotal + "       ~•~");
          Console.WriteLine("-~-             -~•~•~•~•~-             -~-");    
          Console.WriteLine("~•~    Thank you!!  Have a nice day.    ~•~");
          Console.WriteLine("-~-             -~•~•~•~•~-             -~-");    
          Console.WriteLine("~•~~•~•~~•~•~~•~•~~/~/~/~•~~•~•~~•~•~~•~•~~");
          Console.WriteLine("---~------~----------~----------~------~---");
        }
      } 
      else if (userOrder == "pastry")
      {
        Console.WriteLine("---~------~----------~----------~------~---");
        Console.WriteLine("~•~~•~•~~•~•~~•~•~~/~/~/~•~~•~•~~•~•~~•~•~~");
        Console.WriteLine("-~-             -~•~•~•~•~-             -~-");    
        Console.WriteLine("~•~         How many pastries?          ~•~");
        Console.WriteLine("-~-             -~•~•~•~•~-             -~-");    
        Console.WriteLine("~•~~•~•~~•~•~~•~•~~/~/~/~•~~•~•~~•~•~~•~•~~");
        Console.WriteLine("---~------~----------~----------~------~---");
        string pastryQuantity = Console.ReadLine();
        int parsPastryQuantity = int.Parse(pastryQuantity);
        Pastry newPastry = new Pastry(parsPastryQuantity);
        int pastryCost = newPastry.SetPrice();
        Console.WriteLine("---~------~----------~----------~------~---");
        Console.WriteLine("~•~~•~•~~•~•~~•~•~~/~/~/~•~~•~•~~•~•~~•~•~~");
        Console.WriteLine("-~-             -~•~•~•~•~-             -~-");    
        Console.WriteLine("~•~  Any bread loaves?  type Yes or No  ~•~");
        Console.WriteLine("-~-             -~•~•~•~•~-             -~-");    
        Console.WriteLine("~•~~•~•~~•~•~~•~•~~/~/~/~•~~•~•~~•~•~~•~•~~");
        Console.WriteLine("---~------~----------~----------~------~---");
        
        string continueOrder = Console.ReadLine().ToLower(); 
        if (continueOrder == "no");
        {
          Console.WriteLine("---~------~----------~----------~------~---");
          Console.WriteLine("~•~~•~•~~•~•~~•~•~~/~/~/~•~~•~•~~•~•~~•~•~~");
          Console.WriteLine("-~-             -~•~•~•~•~-             -~-");    
          Console.WriteLine("~•~      " + parsPastryQuantity + " pastries comes to $" + pastryCost + ".      ~•~");
          Console.WriteLine("-~-       ~•~   ~•~     ~•~   ~•~       -~-");
          Console.WriteLine("~•~    Thank you!!  Have a nice day.    ~•~");
          Console.WriteLine("-~-             -~•~•~•~•~-             -~-");    
          Console.WriteLine("~•~~•~•~~•~•~~•~•~~/~/~/~•~~•~•~~•~•~~•~•~~");
          Console.WriteLine("---~------~----------~----------~------~---");
        } if (continueOrder == "yes")
        {
          Console.WriteLine("---~------~----------~----------~------~---");
          Console.WriteLine("~•~~•~•~~•~•~~•~•~~/~/~/~•~~•~•~~•~•~~•~•~~");
          Console.WriteLine("-~-             -~•~•~•~•~-             -~-");    
          Console.WriteLine("~•~           How many loaves?          ~•~");
          Console.WriteLine("-~-             -~•~•~•~•~-             -~-");    
          Console.WriteLine("~•~~•~•~~•~•~~•~•~~/~/~/~•~~•~•~~•~•~~•~•~~");
          Console.WriteLine("---~------~----------~----------~------~---");
          string breadQuantity = Console.ReadLine();
          int parsBreadQuantity = int.Parse(breadQuantity);
          Bread newBread = new Bread(parsBreadQuantity);
          int breadCost = newBread.SetPrice();
          int orderTotal = OrderTotal.CalculateOrder(breadCost, pastryCost);
          Console.WriteLine("---~------~----------~----------~------~---");
          Console.WriteLine("~•~~•~•~~•~•~~•~•~~/~/~/~•~~•~•~~•~•~~•~•~~");
          Console.WriteLine("-~-             -~•~•~•~•~-             -~-");    
          Console.WriteLine("~•~       " + parsBreadQuantity + " loaves comes to $" + breadCost + ".       ~•~");
          Console.WriteLine("~•~       " + parsPastryQuantity + " pastries comes to $" + pastryCost + ".       ~•~");
          Console.WriteLine("-~-             -~•~•~•~•~-             -~-");              
          Console.WriteLine("~•~      Your total comes to $" + orderTotal + "      ~•~");
          Console.WriteLine("-~-             -~•~•~•~•~-             -~-");    
          Console.WriteLine("~•~    Thank you!!  Have a nice day.    ~•~");
          Console.WriteLine("-~-             -~•~•~•~•~-             -~-");    
          Console.WriteLine("~•~~•~•~~•~•~~•~•~~/~/~/~•~~•~•~~•~•~~•~•~~");
          Console.WriteLine("---~------~----------~----------~------~---");
        }
      } 
    } 
  }
}


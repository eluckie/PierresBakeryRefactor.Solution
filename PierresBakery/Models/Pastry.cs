using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry : BakedGoods
  {
    public Pastry(int quantity)
    {
      Quantity = quantity;
    }
    public override int CalculateTotal()
    {
      if(Quantity % 4 == 0)
      {
        return ((Quantity / 4) * 6);
      }
      else
      {
        int remainder = Quantity % 4;
        int adjustedCount = Quantity - remainder;
        return (remainder * 2) + ((adjustedCount / 4) * 6);
      }
    }
  }
}
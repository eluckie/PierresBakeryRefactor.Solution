using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread : BakedGoods
  {
    public Bread(int quantity)
    {
      Quantity = quantity;
    }
    public override int CalculateTotal()
    {
      if(Quantity % 3 == 0)
      {
        return ((Quantity / 3) * 10);
      }
      else
      {
        int remainder = Quantity % 3;
        int adjustedCount = Quantity - remainder;
        return (remainder * 5) + ((adjustedCount / 3) * 10);
      }
    }
  }
}
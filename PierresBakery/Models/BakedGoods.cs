using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public abstract class BakedGoods
  {
    public int Quantity { get; set; }

    public abstract int CalculateTotal();
  }
}
using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;

namespace PierresBakery.Controllers
{
  public class BakedGoodsController : Controller
  {
    [HttpGet("/bakedgoods/order-form")]
    public ActionResult OrderForm()
    {
      return View();
    }
    [HttpPost("/bakedgoods/place-order")]
    public ActionResult PlaceOrder(int breadInput, int pastryInput)
    {
      Bread breadOrder = new Bread(breadInput);
      Pastry pastryOrder = new Pastry(pastryInput);
      PlaceOrder order = new PlaceOrder();
      order.BreadTotal = breadOrder.CalculateTotal();
      order.PastryTotal = pastryOrder.CalculateTotal();
      order.Bread = breadInput;
      order.Pastry = pastryInput;
      order.Total = order.PastryTotal + order.BreadTotal;
      return View(order);
    }
  }
}
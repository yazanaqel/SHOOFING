using Microsoft.AspNetCore.Mvc;
using OnTest.Data.Repository;
using OnTest.Models;

namespace OnTest.Data.Services
{
    public class OrdersController : Controller
    {
        private readonly IDataHelper<Product> _serviceProduct;
        private readonly IDataHelper<Order> _serviceOrder;
        public OrdersController(IDataHelper<Product> serviceProduct, IDataHelper<Order> serviceOrder)
        {
            _serviceProduct = serviceProduct;
            _serviceOrder = serviceOrder;
        }
        public IActionResult Index()
        {
            return View(_serviceOrder.GetAllData());
        }
        public IActionResult AddToCart(int id)
        {
            var item = _serviceProduct.Find(id);
            _serviceOrder.Add(item);
            return RedirectToAction("Index");
        }
        public IActionResult Plus(int id)
        {
            var item = _serviceOrder.Find(id);

            if (item.Quantity == 10)
            {

            }
            else
            {
                item.Quantity++;
            }

            return RedirectToAction("Index");
        }
        public IActionResult Minus(int id)
        {
            var item = _serviceOrder.Find(id);

            if (item.Quantity == 1)
            {

            }
            else
            {
                item.Quantity--;
            }


            return RedirectToAction("Index");
        }
        public IActionResult Remove(int id)
        {
            _serviceOrder.Remove(id);

            return RedirectToAction("Index");
        }

		public IActionResult Apply()
		{
            _serviceOrder.Apply();

			return RedirectToAction("Index","Products");
		}

	}
}

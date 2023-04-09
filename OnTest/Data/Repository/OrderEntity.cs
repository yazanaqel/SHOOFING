using OnTest.Data.Services;
using OnTest.Models;

namespace OnTest.Data.Repository
{
    public class OrderEntity : IDataHelper<Order>
    {
        static List<Order> CartItemList { get; set; }
        static int nextOrder = 1;
        static OrderEntity()
        {
            CartItemList = new List<Order>();
        }
        public Order Find(int id) => CartItemList.FirstOrDefault(x => x.Id == id);

        public List<Order> GetAllData() => CartItemList;

        public void Add(Product item)
        {
            var cart = new Order
            {
                Id = nextOrder++,
                Name = item.Name,
                ImageURL = item.ImageURL,
                Price = item.Price,
                Quantity = 1

            };
            CartItemList.Add(cart);
        }

        public void Remove(int id)
        {
            CartItemList.Remove(Find(id));
        }
		public void Apply()
		{
            CartItemList.Clear();
		}
		List<Order> IDataHelper<Order>.Search(string searchItem)
        {
            throw new NotImplementedException();
        }
    }
}

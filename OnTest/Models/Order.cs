namespace OnTest.Models
{
	public class Order
	{
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ImageURL { get; set; }
        public double Price { get; set; }
		public int Quantity { get; set; }
    }
}

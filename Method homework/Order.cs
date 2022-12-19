

namespace Method_homework
{
    internal class Order
    {
        public DateTime Date { get; set; }
        public double Price { get; set; }

        public Order(DateTime date, double price)
        {
           Date= date;
           Price= price;
        }
    }
}

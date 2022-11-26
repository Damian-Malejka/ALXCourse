namespace ShopApp.Models
{
    public class ShoppingCart
    {
        public List<Product> Products { get; set; }

        public ShoppingCart(List<Product>products)
        {
            Products = new List<Product>();
        }
        
        public decimal GetNettoPrice()
        {
            return Products.Sum(x => x.NettoPrice);
        }
        public decimal GetBruttoPrice()
        {
            return Products.Sum(x => x.Bruttoprice);//funkcja anonimowa
        }
     

       
        public void ClearCart()
        {
            Products.Clear();
        }
    }
}

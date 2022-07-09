namespace ManolisShop.ManolisModels
{
    internal class UserCartModel
    {
        public User User { get; set; }

        public List<CartItem> Items { get; set; }
        public int totalPrice { get; set; }
        
    }
}

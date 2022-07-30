namespace SessionServer
{
   public  class Product
    {
        public static int OtherId;
        public int ProdId { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int RemainingStock { get; set; }
    }

    public class CartItems : Product
    {
        public int Qnt { get; set; }
    }
}

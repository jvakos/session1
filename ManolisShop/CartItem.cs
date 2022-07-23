using System.ComponentModel.DataAnnotations.Schema;

namespace ManolisShop
{
    internal class CartItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public decimal Price { get; set; }
        public decimal Qnt { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        public int ModelId { get; set; }
        




    }
}

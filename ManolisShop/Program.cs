// See https://aka.ms/new-console-template for more information
using ManolisShop;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

var db = new Database();
db.Database.EnsureCreated();

//var userWithOrders=db.Users.Include(x => x.Orders).Where(x => x.Id == 1).FirstOrDefault();
//userWithOrders.Orders[0]

User user;
if (!db.Users.Any())
{
    user = new User
    {
        Email = "koubros.gmail.com",
        Firstname = "Manolis",
        Lastname = "Kour",
        Phone = "22222222",
    };
}
else
{
    user=db.Users.First();
}

var order=new Order
{    
    User = user,
    comments = "sxoliaaaa",
    OrderTime = DateTime.Now,
    PaymentType = PaymentType.Cash,
    deliveryfee = 1.5M,
    address = new address
    {
        Address = "k foumi 74",
        Ringbell = "Mitsos",
        Phone = "6942521000",
        Town = "Chania",
        TK = "73100"
    },
    TotalPrice = 100,
    receipt = true,
    OrderList = new List<CartItem>
    {
        new CartItem
        {         
         Description="Latop lenovo",
         ModelId=1,
         Price=800M,
         ProductId=1,
         Qnt = 1
        },
        new CartItem
        {         
         Description="Tsanta Latop",
         ModelId=2,
         Price=60M,
         ProductId=1,
         Qnt = 1
        },
    }

};

db.Orders.Add(order);
db.SaveChanges();

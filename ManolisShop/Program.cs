// See https://aka.ms/new-console-template for more information
using ManolisShop;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

var db = new Database();
db.Database.EnsureCreated();

var userWithOrders = db.Users    
    .Include(x => x.Orders)
        .ThenInclude(x=>x.OrderList)
    .Include(x => x.Orders)
        .ThenInclude(x => x.Address)
    .Where(x => x.Id == 1)
    .FirstOrDefault();

//var orderforUser1 = db.Orders
//  .Include(x => x.OrderList)
//.Include(x => x.Address)
//.Include(x => x.User)
//.Where(x => x.UserId == 1)
//.Take(1);

Order value = userWithOrders.Orders[0];


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
    Comments = "sxoliaaaa",
    OrderTime = DateTime.Now,
    PaymentType = PaymentType.Cash,
    Deliveryfee = 1.5M,
    Address = new Address
    {
        address = "k foumi 74",
        Ringbell = "Mitsos",
        Phone = "6942521000",
        Town = "Chania",
        TK = "73100",
        User= user,
    },
    TotalPrice = 100,
    Receipt = true,
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


Console.WriteLine("give me a subject");
string subject=Console.ReadLine();


Console.WriteLine("give me a text");
string body = Console.ReadLine();

Console.WriteLine("give email ");
string email=Console.ReadLine();

Console.WriteLine("send? <yes,no>");
string reponse=Console.ReadLine();


var emailSender = new MyLib1.EmailSender();
string sendresult = emailSender.SendEmail(email, subject, body);
Console.WriteLine(sendresult);


var sms = new MyLib1.SMSSender();
string smsresult=sms.SendSMS("694252100X", "hellooooooo");
Console.WriteLine(smsresult);


var sqliite = new Microsoft.Data.Sqlite.SqliteConnection("Data source=test.db");
sqliite.Open();
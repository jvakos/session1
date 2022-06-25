
class Student : Person
{
    

    public int id;
    public DateTime registrationDate;
    public int Eksamino { get; set; }


    public override void PrintPersonInfo()
    {
        base.PrintPersonInfo();
        PrintResigtrationDate();
        PrintEksamino();
    }




    private void PrintResigtrationDate()
    {
        Console.WriteLine("Registerd at:" + registrationDate.ToString());
    }
    private void PrintEksamino()
    {
        Console.WriteLine("eksamino:" + Eksamino.ToString());
    }
}

class Person
{
    public string name;
    public string lastname;
    public string Fathername;
    public string phone;
    public string email;

    Dictionary<string, int> eortologio = new Dictionary<string, int>();


    public Person()
    {
        eortologio.Add("manolis", 6);
        eortologio.Add("fanis", 8);
    }

    public bool HasBirthdayToday()
    {
        int month;
        if (eortologio.TryGetValue(name, out month))
        {
            if (month == DateTime.Now.Month)
            {
                return true;
            }
        }
        return false;
    }

    

    public virtual void PrintPersonInfo()
    {
        PrintName();
        PrintLastName();        
    }
   



    private void PrintName()
    {
        Console.WriteLine("Name:" + name);
    }
    private void PrintName(bool longtext)
    {
        if (longtext)
        {
            Console.WriteLine("His Name is:" + name);
        }
        else
        {
            PrintName();
        }
    }
    private void PrintLastName()
    {
        Console.WriteLine("email:" + email);
    }
}
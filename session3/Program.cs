string names = "manolis,fanis,dimitris,giannhs";
int idx = names.IndexOf("m");
Console.WriteLine($"m is in {idx} position");





//Console.WriteLine($"There are {Car.Count} cars");

//////List<Car> cars = new List<Car>();

//////Car? car1=null;


//////if (Console.ReadKey().Key==ConsoleKey.Enter)
//////{
//////    car1 = new ElectricCar();
//////}

//////car1?.PrintCount(); // if (car1 != null)  car1.PrintCount();




//////int? x=null;

//////var veh = new ElectricCar();
//////veh.Brand = Brands.Nissan;
//////veh.BatteryCapacity = 60;

//////veh.PrintInfo();

//var v1 = new EngineCar();
////Console.WriteLine($"There are {Car.Count} cars");
//v1.Horsepower = 1000;
//cars.Add(v1);

//var v2 = new ElectricCar();
////Console.WriteLine($"There are {Car.Count} cars");
//v2.Horsepower = 2000;
//cars.Add(v2);

//var v3 = new EngineCar();
////Console.WriteLine($"There are {Car.Count} cars");
//v3.Horsepower = 3000;
//cars.Add(v3);



//for (int i=0; i<1000000; i++)
//{
//    var c = new ElectricCar();
//    c.Horsepower = i;
//    cars.Add(c);
//}

////v1.PrintCount();
////v2.PrintCount();
////v3.PrintCount();

////PrintBrandAndEngine(v1);


//void PrintBrandAndEngine(Car car)
//{
//    Console.WriteLine($"{car.Brand} has engine of type {car.EngineType}");
//}






//foreach (var car in cars)
//{
//    PrintBrandAndEngine(car);
//}

//for (int i=0; i<cars.Count; i++)
//{
//    PrintBrandAndEngine(cars[i]);
//}






abstract class Vehicle
{
    public Brands Brand;
    public int Weels;
    public DateTime ReleaseDate;
    public int? Seats;
}

abstract class Car : Vehicle
{

    public static int Count;
    private int myCount;

    public int Horsepower;
    public EngineTypes EngineType;

    public Car()
    {
        Count++;
        myCount=Count;
    }
   
    
    
    public void PrintCount() 
    {
        Console.WriteLine($"My count is {myCount} of {Car.Count}");
    }

}

class EngineCar: Car
{
    private int cc;
    public int CC
    {
        get => cc;        
        set
        {
            if (value < 5000)
            {
                cc = value;
            }
            Horsepower = (int)(value * 0.15);
        }
    }

    //private int cc;
    //public int GetCC()
    //{
    //    return cc;
    //}
    //public void SetCC(int cc)
    //{
    //    if (cc < 5000)
    //    {
    //        this.cc = cc;
    //    }
    //    Horsepower =(int)( cc * 0.15);
    //}


    public EngineCar()
    {
        EngineType = EngineTypes.Thermal;
    }

}

class ElectricCar : Car
{

    public int BatteryCapacity;


    public ElectricCar()
    {
        EngineType = EngineTypes.Electric;
    }


    public void PrintInfo()
    {
        Console.WriteLine($"brand={Brand}");
        Console.WriteLine($"horses={Horsepower}");
        Console.WriteLine($"cacp={BatteryCapacity}");
        if (Seats == null)
        {
            Console.WriteLine("ERROR no seats defined");
        }
        else if (Seats == 0)
        {
            Console.WriteLine("no seats");
        }
        else
        {
            Console.WriteLine($"seats={Seats}");
        }
    }
}


enum EngineTypes
{
    Thermal,
    Electric,
    HumanPowered
}
enum Brands
{
    Alfaromeo,
    Nissan,
    VW,
    Renault,
    Kia
}




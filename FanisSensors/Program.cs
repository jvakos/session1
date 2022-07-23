using FanisSensors;

internal class Program
{
    private static async Task Main(string[] args)
    {
        List<BaseSensor> Sensors = new List<BaseSensor>();
        var sonarSens = new SonarSensor();
        Sensors.Add(sonarSens);
        var humSens = new HumiditySensor();
        Sensors.Add(humSens);

        /*Console.WriteLine("Number Of Values?");
        string input = Console.ReadLine();
        int num = int.Parse(input);*/


        int MinSensorValue = 0;
        int MaxSensorValue = 1000;
        DateTime localDate;
        List<MeasureValue> Measures = new List<MeasureValue>();




        //int[] SensData = new int[num];

        Random randNum = new Random();
        //for (int i = 0; i < SensData.Length; i++)
        //{
        //    SensData[i] = randNum.Next(Min, Max);
        //}

        //for (int i = 0; i < SensData.Length; i++)
        //{
        //    Console.WriteLine($"The {i+1} Value is {SensData[i]} ");
        //}

        do
        {
            int cn;
            Console.Clear();
            Console.WriteLine("\n Menu \n\n 1. Measure\n 2. Display Measures \n 3. Del.Measure  \n 4. Exit Interface \n\n Choose an Option : \n\n");
            var ch = Console.ReadLine();
            bool success = int.TryParse(ch, out cn);
            if (success)
            {
                switch (cn)
                {
                    case 1:
                        //Console.WriteLine("Choice 1");
                        await Measure(Sensors, MinSensorValue, MaxSensorValue, Measures, randNum);
                        break;


                    case 2:
                        foreach (var mes in Measures)
                        {
                            //Console.WriteLine("Value: {0}, Date: {1}", mes.Value, mes.MeasureTime);
                            Console.WriteLine($"Value: {mes.Value.ToString().PadRight(4)}, Date: {mes.MeasureTime}");
                        }
                        Console.ReadKey();
                        //Console.WriteLine("Choice 2");                        
                        break;
                    case 3:
                        cn = await DeleteMeasure(Measures);
                        //Console.WriteLine("Choice 3");                        
                        break;
                    case 4:
                        Console.WriteLine("Stand By For Exit!");
                        await Task.Delay(1000);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
                await Task.Delay(1000);

            }
            Console.WriteLine("Wrong Choice");
        } while (true);
    }

    private static async Task<int> DeleteMeasure(List<MeasureValue> Measures)
    {
       
        Console.Clear();
        Console.WriteLine("\n Choose an Action! \n\n 1. Del.Specific Measurement \n 2. Clear All Measurments \n 3. Exit Action \n");
        var cht = Console.ReadLine();
        bool su = int.TryParse(cht, out int cn);
        if (su)
        {
            switch (cn)
            {
                case 1:
                    for (int i = 0; i < Measures.Count; i++)
                    {
                        Console.WriteLine($"{i})  Value: {Measures[i].Value}, Date: {Measures[i].MeasureTime}");  
                    }
                    Console.WriteLine("Select a Key, If it's there, I will Delete it!!");
                    var keyString = Console.ReadLine();
                    if (int.TryParse(keyString, out int key))
                    {
                        if (key < Measures.Count && key >= 0)
                        {
                            Measures.RemoveAt(key);                           
                        }
                        else
                        {
                            Console.WriteLine("{0} does not exist in map", key);
                        }
                    }
                    // foreach (KeyValuePair<double, DateTime> mes in Measures)  
                    //     {  
                    //       Console.WriteLine("Value: {0}, Date: {1}",mes.Key, mes.Value);  
                    //     }
                    //         Console.WriteLine("Write a Key, If it's there, I will Delete it!!");
                    //         var key = Console.ReadLine();
                    //         string value;
                    //         bool keyExists = Measures.TryGetValue(key, out value);
                    //         if (keyExists) {
                    //             Console.WriteLine("{0} exists in map", key);
                    //         }
                    //         else {
                    //             Console.WriteLine("{0} does not exist in map", key);
                    //         }
                    break;

                case 2:
                    Measures.Clear();
                    Console.WriteLine("All Done! Measures Cleared...");
                    await Task.Delay(1000);
                    break;

                case 3:
                    Console.WriteLine("Stand By.. Exiting");
                    await Task.Delay(1000);
                    break;

                default:
                    Console.WriteLine("Wrong Choice \n\n Available Options are: \n 1. Del.Specific Measurement \n 2. Clear All Measurments \n 3. Exit Action");
                    await Task.Delay(1000);
                    break;
            }
        }
        Console.WriteLine("Wrong Choice");
        return cn;
    }

    private static async Task Measure(List<BaseSensor> Sensors, int MinSensorValue, int MaxSensorValue, List<MeasureValue> Measures, Random randNum)
    {
        DateTime localDate;
        while (!Console.KeyAvailable)
        {
            foreach (var sens in Sensors)
            {
                sens.Voltage = randNum.Next(0, 40);
                sens.Value = randNum.Next(MinSensorValue, MaxSensorValue);
                await Task.Delay(250);
                if (sens.IsVoltageValid())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    localDate = DateTime.Now;
                    Console.WriteLine($"value {sens.Value} is valid for a {sens.SensorType} sensor");
                    Measures.Add(new MeasureValue { Value = sens.Value, MeasureTime = localDate });
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"value {sens.Value} is not valid for a {sens.SensorType} sensor");
                    Console.ResetColor();
                }
            }
            //     if (humSens.Value > 50 && sonarSens.Value < 20)
            //     {
            //         //OpenWindows();
            //     }
        }
        Console.ReadKey();        
        
    }


    class MeasureValue
    {
        public double Value;
        public DateTime MeasureTime;
    }
}

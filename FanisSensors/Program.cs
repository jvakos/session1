using FanisSensors;

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

while (true)
{
    foreach (var sens in Sensors)
    {
        sens.Voltage = randNum.Next(0, 40);
        sens.Value = randNum.Next(MinSensorValue, MaxSensorValue);
        if (sens.IsVoltageValid())
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"value {sens.Value} is valid for a {sens.SensorType} sensor");
            Console.ResetColor();
        }
        else
        {            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"value {sens.Value} is not valid for a {sens.SensorType} sensor");
            Console.ResetColor();
        }
    }

    if (humSens.Value > 50 && sonarSens.Value < 20) 
    { 
        //OpenWindows();
    }

}

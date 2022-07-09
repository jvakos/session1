Console.WriteLine("Number Of Values?");
string input = Console.ReadLine();
int num = int.Parse(input);


int Min = 0;
int Max = 1000;


int[] SensData = new int[num];

Random randNum = new Random();
for (int i = 0; i < SensData.Length; i++)
{
    SensData[i] = randNum.Next(Min, Max);
}

for (int i = 0; i < SensData.Length; i++)
{
    Console.WriteLine($"The {i+1} Value is {SensData[i]} ");
}
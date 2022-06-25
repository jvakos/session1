//var pers = new Person();
//pers.name = "manolis";
//pers.email = "m@";

//CheckPerson(pers);
//Console.WriteLine(pers.name);


//void CheckPerson(Person p)
//{    
//    if (p.name == "manolis")
//    {
//        p.name = "fanis";
//    }
//}



////Console.WriteLine("give num1");
////string input1 = Console.ReadLine();

////Console.WriteLine("give num2");
////string input2 = Console.ReadLine();

//int num1 = 0; //int.Parse(input1);
//int num2 = 5; //int.Parse(input2);

//PrintSum(ref num1, num2);

//Console.WriteLine("num1=" + num1);






//void PrintSum(ref int n1,int n2)
//{
//    if (n1 == 0) n1 = 10;
//    int sum = n1 + n2;
//    Console.WriteLine("sum=" + sum);
//}










var array = new Student[2];

for (int i = 0; i < 2; i++)
{
    var p = new Student();

    Console.WriteLine("person " + i);
    Console.WriteLine("give name");
    p.name = Console.ReadLine();

    Console.WriteLine("give email");
    p.email = Console.ReadLine();


    array[i] = p;
}

MakeUperCaseForAllPeople(array);


    for (int i = 0; i < 2; i++)
{
    PrintNamesAndBirthdays(array[i]);
}



void PrintNamesAndBirthdays(Person p)
{
    p.PrintPersonInfo();

    if (p.HasBirthdayToday() == true)
    {
        Console.WriteLine(" !!!BIRTHDAY TODAY !!! ");
    }
    Console.WriteLine();
}


void MakeUperCaseForAllPeople(Person[] people)
{
    for (int i = 0; i < 2; i++)
    {
        array[i].name= array[i].name.ToUpper();
    }
}





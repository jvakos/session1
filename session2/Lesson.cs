
class Lesson 
{
    Teacher teacher;    
    Student[] students;


    public void PirntNames()
    {

        PrintNamesAndBirthdays(teacher);

        for (int i = 0; i < students.Length; i++)
        {
            PrintNamesAndBirthdays(students[i]);
        }
    }

    private void PrintNamesAndBirthdays(Person p)
    {
        p.PrintPersonInfo();
        if (p.HasBirthdayToday() == true)
        {
            Console.WriteLine(" !!!BIRTHDAY TODAY !!! ");
        }
        Console.WriteLine();
    }
    


}


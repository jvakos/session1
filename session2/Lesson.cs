
class Lesson
{
    Teacher teacher;
    Student student;


    public void PirntNames()
    {
        PrintNamesAndBirthdays(student);
        PrintNamesAndBirthdays(teacher);
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


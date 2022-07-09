
string path = "C:\\Users\\jimva\\source\\repos\\session1\\dbSession\\bin\\Debug\\net6.0\\simpledb.txt";
//string[] lines=File.ReadAllLines(path);



List<Person> persons;
string filedata=File.ReadAllText(path);
persons=System.Text.Json.JsonSerializer.Deserialize<List<Person>>(filedata);

foreach (var p in persons)
{
    p.Name += "!";
    p.Height += 0.5f;
}
string output = System.Text.Json.JsonSerializer.Serialize(persons,new System.Text.Json.JsonSerializerOptions { WriteIndented=true});
File.WriteAllText(path, output);

//persons.Add(new Person { Name = "fanis", Height = 2 });
//persons.Add(new Person { Name = "manolis", Height = 1.90f });

//string output = System.Text.Json.JsonSerializer.Serialize(persons,new System.Text.Json.JsonSerializerOptions { WriteIndented=true});
//File.WriteAllText(path, output);

//for (int i = 0; i < lines.Length; i++)
//{
//    if (lines[i].StartsWith("name="))
//    {
//        var p = new Person();
//        p.Name=lines[i];
//        persons.Add(p);
//    }
//    else if (lines[i].StartsWith("height="))
//    {
//        int equalSymbolIndex=lines[i].IndexOf('=');
//        string heightString=lines[i].Substring(equalSymbolIndex + 1);        
//        persons[persons.Count-1].Height= float.Parse(heightString, System.Globalization.NumberStyles.AllowDecimalPoint);
//    }
//}


//foreach (var p in persons)
//{
//    if (p.Name.StartsWith("name="))
//    {
//        p.Name = p.Name.Replace("name=", "");
//    }
//}

//string output = "";
//foreach (var p in persons)
//{
//    output += $"name={p.Name}\r\n";
//    output += $"height={p.Height}\r\n";
//}

//File.WriteAllText(path,output);



class Person
{
    public string Name { get; set; }
    public float Height { get; set; }
}
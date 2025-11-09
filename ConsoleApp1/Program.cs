using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        var person = new { Name = "Alice", Age = 30 };
        string json = JsonConvert.SerializeObject(person);
        Console.WriteLine(json);
    }
}
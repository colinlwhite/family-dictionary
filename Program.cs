using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Be still and think");
        Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
        myFamily.Add("dad", new Dictionary<string, string>(){ {"name", "Greg"}, {"age", "60"}});
        myFamily.Add("mom", new Dictionary<string, string>(){ {"name", "Joycelyn"}, {"age", "57"}});
        myFamily.Add("sister", new Dictionary<string, string>(){ {"name", "Camerin"}, {"age", "25"}});

        foreach(var (key, value) in myFamily) {
        Console.WriteLine($"{myFamily[key]["name"]} is my {key} and is {myFamily[key]["age"]}");
        }
    }
}

}

using System;
using Newtonsoft.Json;
using System.IO;


namespace Json
{
    public class SuperHero
    {
        public string name { get; set; }
        public int age { get; set; }
        public string[] abilities { get; set; }
        public bool goodGuy { get; set; }
    }

    class Program
    {
        public static void Main()
        {
            SuperHero hero = new SuperHero
            {
                name = "Captain America",
                age = 35,
                abilities = new[] { "Super Speed", "Super Power", "Bullet proof shield" },
                goodGuy = true
            };

            SuperHero hero2 = new SuperHero
            {
                name = "Spider Man",
                age = 16,
                abilities = new [] {"Super Power", "Super Sensatives", "Net"},
                goodGuy = true
            };

            string json = JsonConvert.SerializeObject(hero, Formatting.Indented);
            string json2 = JsonConvert.SerializeObject(hero2, Formatting.Indented);
            Console.WriteLine(json);
            Console.WriteLine(json2);

            string path = @"C:\1\json.txt";
            File.WriteAllText(path, json + json2); 
        }
    }


}


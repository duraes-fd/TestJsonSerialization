// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using Newtonsoft.Json;

namespace TestJsonSerialization
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = new SmsSentEvent()
                { SmsId = Guid.NewGuid(), Number = DateTime.UtcNow.Ticks.ToString(), Text = DateTime.UtcNow.ToShortDateString() };

            Console.WriteLine("---------");
            Console.WriteLine("A - Json with $type");
            
            var jsonWithCorrectType = JsonConvert.SerializeObject(a, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.All
            });

            Console.WriteLine();
            
            Console.WriteLine(jsonWithCorrectType);

            var desserialized = JsonConvert.DeserializeObject(jsonWithCorrectType, new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All
            });
            
            Console.WriteLine($"Deserialized type is '{desserialized.GetType()}'");
            
            Console.WriteLine("---------");
            
            Console.WriteLine("B - Json without $type");
            
            var jsonWithoutType = JsonConvert.SerializeObject(a, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            });
            
            Console.WriteLine();
            
            Console.WriteLine(jsonWithoutType);

            desserialized = JsonConvert.DeserializeObject(jsonWithoutType, new JsonSerializerSettings());
            
            Console.WriteLine($"Deserialized type is '{desserialized.GetType()}'");
            
            Console.WriteLine("---------");

            Console.ReadLine();
        }
    }
}


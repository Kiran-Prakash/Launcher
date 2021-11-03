using System;
using Newtonsoft.Json;

namespace Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Session output = new Session();
            output.url = "http://localhost/Collect.Server/api/Epic";
            output.topic = "lksdjf";
            output.environment = "openEpicProduction";
            output.customerId = "080";
            output.timezone = "American/Phoenix";
            output.isNew = true;
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(output));
            Environment.ExitCode = 0;
        }
    }
    public class Session
    {
        public string url { get; set; }
        public string topic { get; set; }
        public string environment { get; set; }
        public string customerId { get; set; }
        public string timezone { get; set; }
        public Boolean isNew { get; set; }
    }
}
